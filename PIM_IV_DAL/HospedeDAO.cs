using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM_IV_CONEXAOBD;
using PIM_IV_MODEL;
using System.Data.SqlClient;
using System.Data;

namespace PIM_IV_DAL
{
    public class HospedeDAO
    {
        public string adicionarhospede(Hospede hospede)
        {
            string mensagem;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AdicionarHospede", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = hospede.hNome;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = hospede.hCPF;
                procedure.Parameters.Add("Email", SqlDbType.VarChar).Value = hospede.hEmail;
                procedure.Parameters.Add("Celular", SqlDbType.VarChar).Value = hospede.hCelular;
                procedure.Parameters.Add("CEP", SqlDbType.VarChar).Value = hospede.hCep;
                procedure.Parameters.Add("Sexo", SqlDbType.Char).Value = hospede.hSexo;
                procedure.Parameters.Add("Login", SqlDbType.VarChar).Value = hospede.hLogin;
                procedure.Parameters.Add("Senha", SqlDbType.VarChar).Value = hospede.hSenha;
                procedure.Parameters.Add("Funcionario", SqlDbType.Int).Value = hospede.hFuncionario;

                procedure.ExecuteNonQuery();
                mensagem = "Hospede Cadastrado!";
                return mensagem;
            }
            catch (SqlException erro)
            {
                mensagem = erro.Message.ToString(); //"Erro no Cadastro!";
                return mensagem;
            }
        }
        public Hospede ConsultarHospede(string CPF, out string mensagem)
        {
            //id_hospede = 0;
            try
            {
                mensagem = "";
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("ConsultarHospede", conexao);

                procedure.CommandType = CommandType.StoredProcedure;
                
                //procedure.Parameters.Add("id_hospede", SqlDbType.Int).Direction = ParameterDirection.Output;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = CPF;
                procedure.Parameters.Add("Retorno", SqlDbType.VarChar).Value = mensagem;

                SqlDataReader leitor = procedure.ExecuteReader();
                Hospede hospede = new Hospede();

                //id_hospede = int.Parse(procedure.Parameters["id_hospede"].Value.ToString());

                leitor.Read();
                //hospede.hID_hospede = int.Parse(leitor["HOSPEDE"].ToString());
                hospede.hNome = leitor["Nome"].ToString();
                hospede.hCPF = leitor["CPF"].ToString();
                hospede.hEmail = leitor["Email"].ToString();
                hospede.hCelular = leitor["Celular"].ToString();
                hospede.hCep = leitor["Cep"].ToString();
                hospede.hSexo = char.Parse(leitor["Sexo"].ToString());
                hospede.hLogin = leitor["Login"].ToString();
                hospede.hSenha = leitor["Senha"].ToString();
                hospede.hFuncionario = int.Parse(leitor["Funcionario"].ToString());
               // id_hospede = int.Parse(leitor["id_hospede"].ToString());
                mensagem = "Busca Concluída!";
                return hospede;
            }
            catch (Exception err)
            {
                mensagem = "CPF não encontrado na base dados."; //+ err.Message; //"Erro no método\n"+err.Message; //
                return null;

            }
        }
        public string AlterarHospede(Hospede updater)
        {
            string mensagem = "";
            int retorno;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AlterarHospede", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = updater.hNome;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = updater.hCPF;
                procedure.Parameters.Add("Email", SqlDbType.VarChar).Value = updater.hEmail;
                procedure.Parameters.Add("Celular", SqlDbType.VarChar).Value = updater.hCelular;
                procedure.Parameters.Add("CEP", SqlDbType.VarChar).Value = updater.hCep;
                procedure.Parameters.Add("Sexo", SqlDbType.Char).Value = updater.hSexo;
                procedure.Parameters.Add("Login", SqlDbType.VarChar).Value = updater.hLogin;
                procedure.Parameters.Add("Senha", SqlDbType.VarChar).Value = updater.hSenha;
                procedure.Parameters.Add("Funcionario", SqlDbType.Int).Value = updater.hFuncionario;
                procedure.Parameters.Add("Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();

                retorno = int.Parse(procedure.Parameters["Retorno"].Value.ToString());
                if (retorno == 1)
                {
                    mensagem = "Cadastro de Hóspede atualizado!";
                }
                else if (retorno == 2)
                {
                    mensagem = "Erro na atualização de cadastro! Verifique os dados inseridos.";
                }

                return mensagem;
            }
            catch (SqlException err)
            {
                mensagem = "Erro no Método de Atualização! " + err.Message;
                return mensagem;
            }
        }
        public string ConsultarLogin(string login, string senha)
        {
            //Lendo o banco de dados

            string query = "SELECT LOGIN, SENHA FROM HOSPEDES WHERE LOGIN = " + login + " AND SENHA = " + senha +"";
            SqlConnection conexao = new ConexaoFonte().GetConnection();
            SqlCommand command = new SqlCommand(query, conexao);

            string acesso = "";
            return acesso;
            
        }


    }
}
