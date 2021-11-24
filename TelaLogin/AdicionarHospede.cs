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
    public partial class AdicionarHospede : Form
    {
        public AdicionarHospede()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Validacoes.camposvalidados(btn_add.Parent.Controls))
            {
                string sexo = txt_sexo.SelectedItem.ToString();
                Hospede hospede = new Hospede(txt_nome.Text, txt_cpf.Text, txt_email.Text,
                txt_celular.Text, txt_cep.Text, char.Parse(sexo), txt_login.Text,
                txt_senha.Text, int.Parse(txt_func.Text.ToString()));
                HospedeDAO hospDao = new HospedeDAO();
                MessageBox.Show(hospDao.adicionarhospede(hospede));
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos.");
            }
        }
    }
}
