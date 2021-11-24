using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_IV_MODEL
{
    public class Funcionario
    {
        private string nome;
        private string CPF;
        private string email;
        private string status;
        private string cargo;
        private string login;
        private string senha;
        public Funcionario()
        {

        }
        public Funcionario(string Nome, string Cpf, string Email, string Status, string Cargo, string Login,
            string Senha)
        {
            nome = Nome;
            CPF = Cpf;
            email = Email;
            status = Status;
            cargo = Cargo;
            login = Login;
            senha = Senha;
        }

        public string fNome { get => nome; set => nome = value; }
        public string fCPF { get => CPF; set => CPF = value; }
        public string fEmail { get => email; set => email = value; }
        public string fStatus { get => status; set => status = value; }
        public string fCargo { get => cargo; set => cargo = value; }
        public string fLogin { get => login; set => login = value; }
        public string fSenha { get => senha; set => senha = value; }
    }
}
