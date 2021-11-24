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
    public partial class AdicionarFuncionario : Form
    {
        public AdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Validacoes.camposvalidados(btn_add.Parent.Controls))
            {
                string user = "";

                _ = (txt_status.Checked) ? user = "ATIVO" : user = "INATIVO";
                string cargo = txt_cargo.SelectedItem.ToString();
                Funcionario funcionario = new Funcionario(txt_nome.Text, txt_cpf.Text, txt_email.Text,
                user, cargo, txt_login.Text, txt_senha.Text);
                FuncionarioDAO funDao = new FuncionarioDAO();
                MessageBox.Show(funDao.adicionarfuncionario(funcionario));

                txt_nome.Text = "";
                txt_cpf.Text = "";
                txt_email.Text = "";
                txt_status.Checked = false;
                txt_cargo.SelectedItem = null;
                txt_login.Text = "";
                txt_senha.Text = "";
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos.");
            }


        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
