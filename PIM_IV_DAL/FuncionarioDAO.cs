using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PIM_IV_CONEXAOBD;
using PIM_IV_MODEL;

namespace PIM_IV_DAL
{
    public class FuncionarioDAO
    {
        public string adicionarfuncionario(Funcionario funcionario)
        {
            string mensagem = "";
            int retorno;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AdicionarFuncionario", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = funcionario.fNome;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = funcionario.fCPF;
                procedure.Parameters.Add("Email", SqlDbType.VarChar).Value = funcionario.fEmail;
                procedure.Parameters.Add("Status", SqlDbType.VarChar).Value = funcionario.fStatus;
                procedure.Parameters.Add("Cargo", SqlDbType.VarChar).Value = funcionario.fCargo;
                procedure.Parameters.Add("Login", SqlDbType.VarChar).Value = funcionario.fLogin;
                procedure.Parameters.Add("Senha", SqlDbType.VarChar).Value = funcionario.fSenha;
                procedure.Parameters.Add("Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;


                procedure.ExecuteNonQuery();

                retorno = int.Parse(procedure.Parameters["Retorno"].Value.ToString());
                if (retorno == 1)
                {
                    mensagem = "Funcionário Cadastrado!";

                }
                else if (retorno == 0)
                {
                    mensagem = "Erro! O CPF informado já está cadastrado.";
                }
                return mensagem;

            }
            catch (SqlException)
            {
                mensagem = "Erro no Cadastro!";
                return mensagem;
            }
        }

        public Funcionario ConsultarFuncionario(string CPF, out string mensagem)
        {

            try
            {
                mensagem = "";
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("ConsultarFuncionario", conexao);

                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = CPF;
                procedure.Parameters.Add("Retorno", SqlDbType.VarChar).Value = mensagem;

                SqlDataReader leitor = procedure.ExecuteReader();
                Funcionario funcionario = new Funcionario();

                leitor.Read();

                funcionario.fNome = leitor["Nome"].ToString();
                funcionario.fCPF = leitor["CPF"].ToString();
                funcionario.fEmail = leitor["Email"].ToString();
                funcionario.fStatus = leitor["Status"].ToString();
                funcionario.fCargo = leitor["Cargo"].ToString();
                funcionario.fLogin = leitor["Login"].ToString();
                funcionario.fSenha = leitor["Senha"].ToString();

                mensagem = "Busca Concluída!";
                return funcionario;
            }
            catch (Exception err)
            {
                mensagem = "CPF não encontrado na base dados."; //"Erro no método\n"+err.Message;
                return null;

            }
        }

        public string AlterarFuncionario(Funcionario updater)
        {
            string mensagem = "";
            int retorno;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AlterarFuncionarioNova", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = updater.fNome;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = updater.fCPF;
                procedure.Parameters.Add("Email", SqlDbType.VarChar).Value = updater.fEmail;
                procedure.Parameters.Add("Status", SqlDbType.VarChar).Value = updater.fStatus;
                procedure.Parameters.Add("Cargo", SqlDbType.VarChar).Value = updater.fCargo;
                procedure.Parameters.Add("Login", SqlDbType.VarChar).Value = updater.fLogin;
                procedure.Parameters.Add("Senha", SqlDbType.VarChar).Value = updater.fSenha;
                procedure.Parameters.Add("Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();

                retorno = int.Parse(procedure.Parameters["Retorno"].Value.ToString());
                if (retorno == 1)
                {
                    mensagem = "Cadastro de Funcionário atualizado!";
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
        public string LoginFuncionario (string login, string senha, out int acesso)
        {
            string mensagem = "";
            SqlConnection connection = new ConexaoFonte().GetConnection();
            SqlCommand sqlProcedure = new SqlCommand("ValidarLogin", connection);
            sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

            sqlProcedure.Parameters.Add("Login", System.Data.SqlDbType.VarChar).Value = login;
            sqlProcedure.Parameters.Add("Senha", System.Data.SqlDbType.VarChar).Value = senha;
            sqlProcedure.Parameters.Add("Retorno", System.Data.SqlDbType.Int).Direction = ParameterDirection.Output; //System.Data.
            
            sqlProcedure.ExecuteNonQuery();

            acesso = int.Parse(sqlProcedure.Parameters["Retorno"].Value.ToString());

            if (acesso == 0)
            {
                mensagem = "Dados de login Inválidos! Favor verificar.";
            }
            else if (acesso == 1)
            {
                mensagem = "Usuário inativo! Selecione outro usuário ou atualize o cadastro do usuário atual.";
            }
            else if (acesso == 2)
            {
                mensagem = "Login de nível Gerente realizado.";
            }
            else if (acesso == 3)
            {
                mensagem = "Login de nível Aux. Admin. realizado.";
            }
            else if (acesso == 4)
            {
                mensagem = "Login de nível Recepcionista realizado.";
            }
            return mensagem;
        }
    }
}
