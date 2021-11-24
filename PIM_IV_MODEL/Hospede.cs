using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_IV_MODEL
{
    public class Hospede
    {
        private string nome;
        private string CPF;
        private string email;
        private string celular;
        private string cep;
        private char sexo;
        private string login;
        private string senha;
        private int funcionario;

        public Hospede()
        {

        }

        public Hospede(string Nome, string Cpf, string Email, string Celular, string Cep, char Sexo, string Login,
            string Senha, int Funcionario)
        {
            nome = Nome;
            CPF = Cpf;
            email = Email;
            celular = Celular;
            cep = Cep;
            sexo = Sexo;
            login = Login;
            senha = Senha;
            funcionario = Funcionario;
        }
        public string hNome { get => nome; set => nome = value; }
        public string hCPF { get => CPF; set => CPF = value; }
        public string hEmail { get => email; set => email = value; }
        public string hCelular { get => celular; set => celular = value; }
        public string hCep { get => cep; set => cep = value; }
        public char hSexo { get => sexo; set => sexo = value; }
        public string hLogin { get => login; set => login = value; }
        public string hSenha { get => senha; set => senha = value; }
        public int hFuncionario { get => funcionario; set => funcionario = value; }
    }
}
