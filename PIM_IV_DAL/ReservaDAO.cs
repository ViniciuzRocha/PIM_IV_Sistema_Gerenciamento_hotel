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
    public class ReservaDAO
    {
        public string adicionarreserva(Reserva reserva)
        {
            string mensagem = "";
            int id_reserva;
            int retorno;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AdicionarReservaNova", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("NUM_Quarto", SqlDbType.Int).Value = reserva.rQuarto;
                procedure.Parameters.Add("Entrada", SqlDbType.DateTime).Value = reserva.rEntrada;
                procedure.Parameters.Add("Saida", SqlDbType.DateTime).Value = reserva.rSaida;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = reserva.rHospede;
                procedure.Parameters.Add("Valor", SqlDbType.Int).Value = reserva.rValor;
                procedure.Parameters.Add("Status", SqlDbType.VarChar).Value = reserva.rStatus;
                procedure.Parameters.Add("Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;
                procedure.Parameters.Add("ID_Reserva", SqlDbType.Int).Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();

                retorno = int.Parse(procedure.Parameters["Retorno"].Value.ToString());
                
                if (retorno == 2)
                {
                    id_reserva = int.Parse(procedure.Parameters["ID_Reserva"].Value.ToString());
                    mensagem = $"Reserva realizada com sucesso!\nO códigdo da sua reserva é: {id_reserva}";

                }
                else if (retorno == 1)
                {
                    mensagem = "Erro! Verifique os dados da reserva.";
                } 
                return mensagem;

            }
            catch (SqlException)
            {
                mensagem = "Erro no Cadastro!";
                return mensagem;
            }
        }
        public int BuscarQuartoLivre(int tipo)
        {
            //Lendo o banco de dados
   
            string query = "SELECT NUM_QUARTO FROM QUARTOS WHERE CATEGORIA = "+tipo+" AND HOSPEDE IS NULL";
            SqlConnection conexao = new ConexaoFonte().GetConnection();
            SqlCommand command = new SqlCommand(query, conexao);

            int valor = 0;
            valor = int.Parse(command.ExecuteScalar().ToString());
            return valor;
        }

        public Reserva ConsultarReserva(int Reserva, out string mensagem, out string CPF)
        {
            CPF = "";
            try
            {
                mensagem = "";
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("ConsultarReserva", conexao);

                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("RESERVA", SqlDbType.Int).Value = Reserva;
                //procedure.Parameters.Add("RETORNO", SqlDbType.VarChar).Value = mensagem;

                SqlDataReader leitor = procedure.ExecuteReader();
                Reserva reserva = new Reserva();

                leitor.Read();

                reserva.rID_Reserva = int.Parse(leitor["RESERVA"].ToString());
                reserva.rQuarto = int.Parse(leitor["QUARTO"].ToString());
                reserva.rEntrada = DateTime.Parse(leitor["ENTRADA"].ToString());
                reserva.rSaida = DateTime.Parse(leitor["SAIDA"].ToString());
                reserva.rHospede = leitor["HOSPEDE"].ToString();
                reserva.rValor = int.Parse(leitor["VALOR"].ToString());
                reserva.rStatus = leitor["STATUS"].ToString();
                CPF = leitor["CPF"].ToString();

                mensagem = "Busca Concluída!";
                return reserva;
            }
            catch (Exception err)
            {
                mensagem = "Reserva não encontrada na base dados."; //"Erro no método\n"+err.Message; //
                return null;

            }
        }
        public string alterarreserva(Reserva reserva)
        {
            string mensagem = "";
            int id_reserva;
            int retorno;
            try
            {
                SqlConnection conexao = new ConexaoFonte().GetConnection();
                SqlCommand procedure = new SqlCommand("AlterarReserva", conexao);
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("Reserva", SqlDbType.Int).Value = reserva.rID_Reserva;
                procedure.Parameters.Add("NUM_Quarto", SqlDbType.Int).Value = reserva.rQuarto;
                procedure.Parameters.Add("Entrada", SqlDbType.DateTime).Value = reserva.rEntrada;
                procedure.Parameters.Add("Saida", SqlDbType.DateTime).Value = reserva.rSaida;
                procedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = reserva.rHospede;
                procedure.Parameters.Add("Valor", SqlDbType.Int).Value = reserva.rValor;
                procedure.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = reserva.rStatus;
                procedure.Parameters.Add("Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;

                procedure.ExecuteNonQuery();

                retorno = int.Parse(procedure.Parameters["Retorno"].Value.ToString());
                if (retorno == 1)
                {
                    mensagem = $"A Reserva: {reserva.rID_Reserva} cancelada com sucesso.";

                }
                else if (retorno == 2)
                {
                    mensagem = "Erro! Verifique os dados da reserva.";
                }
                return mensagem;

            }
            catch (SqlException)
            {
                mensagem = "Erro no Cadastro!";
                return mensagem;
            }
        }
        public List<Reserva> ListarReservasGeral()
        {
            List<Reserva> ReservaLista = new List<Reserva>();
            SqlConnection connection = new ConexaoFonte().GetConnection();
            try
            {
                string Query = "SELECT * FROM RESERVAS";

                SqlCommand command = new SqlCommand(Query, connection);

                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    ReservaLista.Add(new Reserva()
                    {
                        rID_Reserva = int.Parse(result["RESERVA"].ToString()),
                        rQuarto = int.Parse(result["QUARTO"].ToString()),
                        rEntrada = DateTime.Parse(result["ENTRADA"].ToString()),
                        rSaida = DateTime.Parse(result["SAIDA"].ToString()),
                        rHospede = result["HOSPEDE"].ToString(),
                        rValor = int.Parse(result["VALOR"].ToString()),
                        rStatus = result["STATUS"].ToString()
                    });
                }
                return ReservaLista;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<Reserva> ListarReservasConfirmadas()
        {
            List<Reserva> ReservaLista = new List<Reserva>();
            SqlConnection connection = new ConexaoFonte().GetConnection();
            try
            {
                string Query = "SELECT * FROM RESERVAS WHERE STATUS = 'ATIVO'";

                SqlCommand command = new SqlCommand(Query, connection);

                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    ReservaLista.Add(new Reserva()
                    {
                        rID_Reserva = int.Parse(result["RESERVA"].ToString()),
                        rQuarto = int.Parse(result["QUARTO"].ToString()),
                        rEntrada = DateTime.Parse(result["ENTRADA"].ToString()),
                        rSaida = DateTime.Parse(result["SAIDA"].ToString()),
                        rHospede = result["HOSPEDE"].ToString(),
                        rValor =  int.Parse(result["VALOR"].ToString()),
                        rStatus = result["STATUS"].ToString()
                    });
                }
                return ReservaLista;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<Reserva> ListarReservasCanceladas()
        {
            List<Reserva> ReservaLista = new List<Reserva>();
            SqlConnection connection = new ConexaoFonte().GetConnection();
            try
            {
                string Query = "SELECT * FROM RESERVAS WHERE STATUS = 'INATIVO'";

                SqlCommand command = new SqlCommand(Query, connection);

                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    ReservaLista.Add(new Reserva()
                    {
                        rID_Reserva = int.Parse(result["RESERVA"].ToString()),
                        rQuarto = int.Parse(result["QUARTO"].ToString()),
                        rEntrada = DateTime.Parse(result["ENTRADA"].ToString()),
                        rSaida = DateTime.Parse(result["SAIDA"].ToString()),
                        rHospede = result["HOSPEDE"].ToString(),
                        rValor = int.Parse(result["VALOR"].ToString()),
                        rStatus = result["STATUS"].ToString(),
                    });
                }
                return ReservaLista;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
