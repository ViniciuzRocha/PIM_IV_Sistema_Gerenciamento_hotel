using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_DAL;
using PIM_IV_MODEL;

namespace TelaLogin
{
    public partial class ConsultarReserva : Form
    {
        public ConsultarReserva()
        {
            InitializeComponent();
        }

        private void btn_reserva_confirmada_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            ReservaDAO reservaDal = new ReservaDAO();
            List<Reserva> list = new List<Reserva>();
            list = reservaDal.ListarReservasConfirmadas();
            dgv_reservas.DataSource = list;
        }

        private void btn_reserva_cancelada_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            ReservaDAO reservaDal = new ReservaDAO();
            List<Reserva> list = new List<Reserva>();
            list = reservaDal.ListarReservasCanceladas();
            dgv_reservas.DataSource = list;
        }

        private void btn_reserva_geral_Click(object sender, EventArgs e)
        {
            DataTable table_Hospedes = new DataTable();
            ReservaDAO reservaDal = new ReservaDAO();
            List<Reserva> list = new List<Reserva>();
            list = reservaDal.ListarReservasGeral();
            dgv_reservas.DataSource = list;
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            if (Validacoes.camposvalidados(btn_busca.Parent.Controls))
            {
                //Reserva  = new Reserva(int.Parse(txt_id_reserva.Text),
                //    int.Parse(txt_quarto.Text), DateTime.Parse(txt_checkin.Text), 
                //    DateTime.Parse(txt_checkout.Text), int.Parse(txt_cod_hosp.Text),
                //    int.Parse(txt_valor.Text), user);
                ReservaDAO resDao = new ReservaDAO();
                Reserva reserva = new Reserva();
                reserva = resDao.ConsultarReserva(int.Parse(txt_busca_id_reserva.Text), out string mensagem, out string CPF);
                MessageBox.Show(mensagem);

                txt_id_reserva.Text = reserva.rID_Reserva.ToString();
                txt_quarto.Text = reserva.rQuarto.ToString();
                txt_checkin.Text = reserva.rEntrada.ToString();
                txt_checkout.Text = reserva.rSaida.ToString();
                txt_cod_hosp.Text = CPF;
                txt_valor.Text = reserva.rValor.ToString();
                txt_status.Checked = false;

                string user = reserva.rStatus;

                _ = (user == "ATIVO") ? txt_status.Checked = true : txt_status.Checked = false;

                btn_salvar.Enabled = true;
                //LIMPAR FORM
                /*
                txt_id_reserva.Text = "";
                txt_quarto.Text = "";
                txt_checkin.Text = "";
                txt_checkout.Text = "";
                txt_cod_hosp.Text = "";
                txt_valor.Text = "";
                txt_status.Checked = false;*/
            }
            else
            {
                MessageBox.Show("O Código da reserva não pode ser nulo.");
            }

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {

            ReservaDAO resDao = new ReservaDAO();
            Reserva reserva = new Reserva();
            
            string user = reserva.rStatus;

            _ = (txt_status.Checked) ? user = "ATIVO" : user  = "INATIVO";
            Reserva reserva1 = new Reserva();

            reserva1.rID_Reserva = int.Parse(txt_id_reserva.Text);
            reserva1.rQuarto = int.Parse(txt_quarto.Text);
            reserva1.rEntrada = DateTime.Parse(txt_checkin.Text);
            reserva1.rSaida = DateTime.Parse(txt_checkout.Text);
            reserva1.rHospede = txt_cod_hosp.Text;
            reserva1.rValor = int.Parse(txt_valor.Text);
            reserva1.rStatus = user;

            string mensagem = resDao.alterarreserva(reserva1);
            MessageBox.Show(mensagem);

        }

        private void ConsultarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
