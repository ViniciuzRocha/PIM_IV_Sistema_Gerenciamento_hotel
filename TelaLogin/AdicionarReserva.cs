using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_IV_MODEL;
using PIM_IV_DAL;

namespace TelaLogin
{
    public partial class AdicionarReserva : Form
    {
        
        public AdicionarReserva()
        {
            InitializeComponent();

        }

        private void txt_checkin_ValueChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(txt_checkin.Value.Date.CompareTo(txt_checkout.Value.Date).ToString());
        }

        private void txt_checkout_ValueChanged(object sender, EventArgs e)
        {
            if (txt_checkout.Value.Date < txt_checkin.Value.Date)
            {
                MessageBox.Show("Erro! A data de saída não pode ser menor que a data de entrada.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_reserva_Click(object sender, EventArgs e)
        {
            HospedeDAO hospedeDAL = new HospedeDAO();
            if (hospedeDAL.ConsultarHospede(txt_cod_hosp.Text, out string mensagem) == null)
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                int teste = int.Parse(txt_quarto.Text);
                int teste2 = int.Parse(txt_valor_total.Text);
                //txt_categoria;
                if (Validacoes.camposvalidados(btn_add_reserva.Parent.Controls))
                {
                    string user = "";

                    _ = (txt_status.Checked) ? user = "ATIVO" : user = "INATIVO";
                    Reserva reserva1 = new Reserva();
                    reserva1.rQuarto = int.Parse(txt_quarto.Text);
                    reserva1.rEntrada = DateTime.Parse(txt_checkin.Text);
                    reserva1.rSaida = DateTime.Parse(txt_checkout.Text);
                    reserva1.rHospede = txt_cod_hosp.Text;
                    reserva1.rValor = int.Parse(txt_valor_total.Text);
                    reserva1.rStatus = user;

                    /*Reserva reserva = new Reserva(int.Parse(txt_quarto.Text), DateTime.Parse(txt_checkin.Text),
                    DateTime.Parse(txt_checkout.Text), int.Parse(txt_cod_hosp.Text).ToString(),
                    int.Parse(txt_valor_total.Text));*/
                    ReservaDAO resDao = new ReservaDAO();
                    MessageBox.Show(resDao.adicionarreserva(reserva1));

                    txt_quarto.Text = "";
                    txt_checkin.Text = "";
                    txt_checkout.Text = "";
                    txt_cod_hosp.Text = "";
                    txt_valor_total.Text = "";
                    txt_status.Checked = false;
                }
                else
                {
                    MessageBox.Show("Campos obrigatórios não preenchidos.");
                }
            }

            
        }

        private void btn_calcular_reserva_Click(object sender, EventArgs e)
        {
            // Preço das Categorias de Quartos
            int precoCategoria = 0;
            int Diaria = int.Parse(txt_checkout.Value.Date.Subtract(txt_checkin.Value.Date).TotalDays.ToString());

            // Calculando Diária

            switch (txt_categoria.Text)
            {
                case "STANDART":
                    int numero = int.Parse(txt_quarto.Text);
                    if (numero >= 1 && numero <=40)
                    {
                        precoCategoria = 150;
                        if (txt_checkin.Value == txt_checkout.Value)
                        {
                            precoCategoria *= 1;
                        }
                        else
                        {
                            precoCategoria *= Diaria;
                            txt_valor_total.Text = precoCategoria.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O quarto selecionado não pertence a categoria escolhida para essa reserva.");
                    }
                    break;

                case "MASTER":
                    int numero1 = int.Parse(txt_quarto.Text);
                    if (numero1 >= 41 && numero1 <= 65)
                    {
                        precoCategoria = 300;
                        if (txt_checkin.Value == txt_checkout.Value)
                        {
                            precoCategoria *= 1;
                        }
                        else
                        {
                            precoCategoria *= Diaria;
                            txt_valor_total.Text = precoCategoria.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O quarto selecionado não pertence a categoria escolhida para essa reserva.");
                    }
                    break;
                case "DELUXE":
                    int numero2 = int.Parse(txt_quarto.Text);
                    if (numero2 >= 66 && numero2 <= 75)
                    {
                        precoCategoria = 500;
                        if (txt_checkin.Value == txt_checkout.Value)
                        {
                            precoCategoria *= 1;
                        }
                        else
                        {
                            precoCategoria *= Diaria;
                            txt_valor_total.Text = precoCategoria.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O quarto selecionado não pertence a categoria escolhida para essa reserva.");
                    }
                    break;
            }
        }

        private void txt_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txt_categoria.Text)
            {
                case "STANDART":
                    lbl_quartos.Visible = true;
                    lbl_quartos.Text = "Quartos de 1-40";
                    break;
                case "MASTER":
                    lbl_quartos.Visible = true;
                    lbl_quartos.Text = "Quartos de 41-65";
                    break;
                case "DELUXE":
                    lbl_quartos.Visible = true;
                    lbl_quartos.Text = "Quartos de 66-75";
                    break;
            }
        }

        private void AdicionarReserva_Load(object sender, EventArgs e)
        {

        }

    }
}
