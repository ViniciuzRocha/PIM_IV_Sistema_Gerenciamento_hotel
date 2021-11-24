using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PIM_IV_CONEXAOBD;

namespace PIM_IV_DAL
{
    public class Relatorios
    {
        public string FuncionariosAtivos()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarFuncAtivo", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string FuncionariosInativos()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarFuncInativo", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string ReservasRealizadas()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarReserva", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string ReservasConfirmadas()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarReserAtiva", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string ReservasCanceladas()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarReserInativa", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();

                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }

                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string HospedesCadastrados()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarHospede", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();
                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }
                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QuartosOcupados()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarQuartosOcupados", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();
                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }
                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QuartosDisponíveis()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarQuartosVagos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();
                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }
                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string QuartosTotal()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("ContarQuartos", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();
                if (result.Read())
                {
                    label = result["Contar"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }
                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string Valor_reserva_Total()
        {
            string label = "";
            try
            {
                SqlConnection connection = new ConexaoFonte().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("SomarValorReserva", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader result = sqlProcedure.ExecuteReader();
                if (result.Read())
                {
                    label = result["SOMAR"].ToString();
                }
                else
                {
                    label = "Erro ao gerar relatórios!";
                }
                return label;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}