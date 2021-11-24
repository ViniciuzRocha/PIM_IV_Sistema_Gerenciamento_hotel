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

namespace TelaLogin
{
    public partial class RelatoriosGerais : Form
    {
        public RelatoriosGerais()
        {
            InitializeComponent();
        }

        private void RelatoriosGerais_Load(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            lbl_func_ativo.Text = relatorios.FuncionariosAtivos();
            lbl_func_inativo.Text = relatorios.FuncionariosInativos();
            lbl_reserva_geral.Text = relatorios.ReservasRealizadas();
            lbl_reserva_confirma.Text = relatorios.ReservasConfirmadas();
            lbl_reserva_cancela.Text = relatorios.ReservasCanceladas();
            lbl_contar_hospede.Text = relatorios.HospedesCadastrados();
            lbl_quartos_ocupados.Text = relatorios.QuartosOcupados();
            lbl_quartos_vagos.Text = relatorios.QuartosDisponíveis();
            lbl_total_quartos.Text = relatorios.QuartosTotal();
            lbl_valor_total_reservas.Text = relatorios.Valor_reserva_Total();
        }

        private void lbl_func_ativo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_func_inativo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
