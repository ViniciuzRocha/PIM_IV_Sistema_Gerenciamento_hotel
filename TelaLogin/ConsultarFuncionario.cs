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
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string user = "";

            _ = (txt_status.Checked) ? user = "ATIVO" : user = "INATIVO";
            string cargo = txt_cargo.SelectedItem.ToString();
            Funcionario updater = new Funcionario(txt_nome.Text, txt_cpf.Text, txt_email.Text,
            user, cargo, txt_login.Text, txt_senha.Text);
            FuncionarioDAO funDao = new FuncionarioDAO();
            MessageBox.Show(funDao.AlterarFuncionario(updater));

            btn_salvar.Enabled = false;
            //LIMPAR FORM
            txt_nome.Text = "";
            txt_cpf.Text = "";
            txt_email.Text = "";
            txt_status.Checked=false;
            txt_cargo.SelectedItem = null;
            txt_login.Text = "";
            txt_senha.Text = "";
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            if (Validacoes.camposvalidados(btn_busca.Parent.Controls))
            {

                Funcionario funcionario = new Funcionario();
                FuncionarioDAO FunDao = new FuncionarioDAO();
                funcionario = FunDao.ConsultarFuncionario(txt_busca.Text, out string mensagem);
                MessageBox.Show(mensagem);
                if (funcionario != null)
                {
                    txt_nome.Text = funcionario.fNome;
                    txt_cpf.Text = funcionario.fCPF;
                    txt_email.Text = funcionario.fEmail;
                    txt_status.Checked = funcionario.fStatus == "ATIVO" ? true : false;
                    txt_cargo.SelectedItem = funcionario.fCargo;
                    txt_login.Text = funcionario.fLogin;
                    txt_senha.Text = funcionario.fSenha;

                    btn_salvar.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("O CPF do funcionário não pode ser nulo.");
            }
        }
    }
}
