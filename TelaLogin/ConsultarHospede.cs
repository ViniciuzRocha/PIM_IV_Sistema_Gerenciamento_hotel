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
    public partial class ConsultarHospede : Form
    {
        public ConsultarHospede()
        {
            InitializeComponent();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            if (Validacoes.camposvalidados(btn_busca.Parent.Controls))
            {
                Hospede hospede = new Hospede();
                HospedeDAO HospDao = new HospedeDAO();
                hospede = HospDao.ConsultarHospede(txt_busca.Text, out string mensagem);

                MessageBox.Show(mensagem);
                if (hospede != null)
                {
                    txt_nome.Text = hospede.hNome;
                    txt_cpf.Text = hospede.hCPF;
                    txt_email.Text = hospede.hEmail;
                    txt_celular.Text = hospede.hCelular;
                    txt_cep.Text = hospede.hCep;
                    txt_sexo.SelectedItem = hospede.hSexo.ToString(); //Text = hospede.hSexo.ToString();
                    txt_login.Text = hospede.hLogin;
                    txt_senha.Text = hospede.hSenha;
                    txt_funcionario.Text = hospede.hFuncionario.ToString();
                    
                    btn_salvar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("O CPF do funcionário não pode ser nulo.");
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
                string sexo = txt_sexo.SelectedItem.ToString();
                Hospede updater = new Hospede(txt_nome.Text, txt_cpf.Text, txt_email.Text,
                txt_celular.Text, txt_cep.Text, char.Parse(sexo.ToString()), txt_login.Text, 
                txt_senha.Text, int.Parse(txt_funcionario.Text.ToString()));
                HospedeDAO HospDao = new HospedeDAO();
                MessageBox.Show(HospDao.AlterarHospede(updater));

                btn_salvar.Enabled = false;

                txt_nome.Text = "";
                txt_cpf.Text = "";
                txt_email.Text = "";
                txt_celular.Text = "";
                txt_cep.Text = "";
                txt_sexo.SelectedItem = null;
                txt_login.Text = "";
                txt_senha.Text = "";
                txt_funcionario.Text = "";
        }
    }
}
