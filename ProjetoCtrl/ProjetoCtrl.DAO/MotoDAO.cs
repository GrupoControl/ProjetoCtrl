using ProjetoCtrl.MODEL;
using System;
using System.Collections.Generic;
//using para ArrayList
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoCtrl.DAO
{
    public class MotoDAO
    {
        /*MÉTODOS PARA CRUD DE CADASTRO DE MOTO*/
        #region "[MOTO] Métodos de execução de SQL"
        public bool InserirMoto(ArrayList p_arrInserir)
        {
            /*[marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [corPrimaria_mot], [corSecundaria_mot], [preco_mot], */
            string vsql = "INSERT INTO [ProjetoCtrl].[dbo].[TbMoto] ([marca_mot], [modelo_mot], [ano_mot], [combustivel_mot],[tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [cor_mot], [preco_mot]) VALUES (@marca_mot, @modelo_mot, @ano_mot, @combustivel_mot, @tipoPartida_mot, @tipoAlimentacao_mot, @tipoRefrigeracao_mot, @tipoFreio_mot, @qtdMarchas_mot, @quilometragem_mot , @cor_mot, @preco_mot)";

            SqlCommand objCmd = null;

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.Add(new SqlParameter("@marca_mot", p_arrInserir[0]));
                objCmd.Parameters.Add(new SqlParameter("@modelo_mot", p_arrInserir[1]));
                objCmd.Parameters.Add(new SqlParameter("@ano_mot", p_arrInserir[2]));
                objCmd.Parameters.Add(new SqlParameter("@combustivel_mot", p_arrInserir[3]));
                objCmd.Parameters.Add(new SqlParameter("@tipoPartida_mot", p_arrInserir[4]));
                objCmd.Parameters.Add(new SqlParameter("@tipoAlimentacao_mot", p_arrInserir[5]));
                objCmd.Parameters.Add(new SqlParameter("@tipoRefrigeracao_mot", p_arrInserir[6]));
                objCmd.Parameters.Add(new SqlParameter("@tipoFreio_mot", p_arrInserir[7]));
                objCmd.Parameters.Add(new SqlParameter("@qtdMarchas_mot", p_arrInserir[8]));
                objCmd.Parameters.Add(new SqlParameter("@quilometragem_mot", p_arrInserir[9]));
                objCmd.Parameters.Add(new SqlParameter("@cor_mot", p_arrInserir[10]));
                objCmd.Parameters.Add(new SqlParameter("@preco_mot", p_arrInserir[11]));
                objCmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        public bool AtualizarMoto(ArrayList p_arrAtualizar)
        {
            /*[marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [corPrimaria_mot], [corSecundaria_mot], [preco_mot], */
            string vsql = "UPDATE [ProjetoCtrl].[dbo].[TbMoto] SET [marca_mot] = @marca_mot, [modelo_mot] = @modelo_mot, [ano_mot] = @ano_mot, [combustivel_mot] = @combustivel_mot, [tipoPartida_mot] = @tipoPartida_mot, [tipoAlimentacao_mot] = @tipoAlimentacao_mot, [tipoRefrigeracao_mot] = @tipoRefrigeracao_mot, [tipoFreio_mot] = @tipoFreio_mot, [qtdMarchas_mot] = @qtdMarchas_mot, [quilometragem_mot] = @quilometragem_mot, [cor_mot] = @cor_mot, [preco_mot] = @preco_mot WHERE [id_mot] = @id_mot";

            SqlCommand objCmd = null;

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.Add(new SqlParameter("@id_mot", p_arrAtualizar[0]));
                objCmd.Parameters.Add(new SqlParameter("@marca_mot", p_arrAtualizar[1]));
                objCmd.Parameters.Add(new SqlParameter("@modelo_mot", p_arrAtualizar[2]));
                objCmd.Parameters.Add(new SqlParameter("@ano_mot", p_arrAtualizar[3]));
                objCmd.Parameters.Add(new SqlParameter("@combustivel_mot", p_arrAtualizar[4]));
                objCmd.Parameters.Add(new SqlParameter("@tipoPartida_mot", p_arrAtualizar[5]));
                objCmd.Parameters.Add(new SqlParameter("@tipoAlimentacao_mot", p_arrAtualizar[6]));
                objCmd.Parameters.Add(new SqlParameter("@tipoRefrigeracao_mot", p_arrAtualizar[7]));
                objCmd.Parameters.Add(new SqlParameter("@tipoFreio_mot", p_arrAtualizar[8]));
                objCmd.Parameters.Add(new SqlParameter("@qtdMarchas_mot", p_arrAtualizar[9]));
                objCmd.Parameters.Add(new SqlParameter("@quilometragem_mot", p_arrAtualizar[10]));
                objCmd.Parameters.Add(new SqlParameter("@cor_mot", p_arrAtualizar[11]));
                objCmd.Parameters.Add(new SqlParameter("@preco_mot", p_arrAtualizar[12]));

                objCmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        public bool DeletarMoto(int id_mot)
        {
            string vsql = "DELETE FROM [ProjetoCtrl].[dbo].[TbMoto] WHERE [id_mot] = @id_mot";
            SqlCommand objCmd = null;
            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.AddWithValue("@id_mot", id_mot);
                objCmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        #endregion

        #region "[MOTO] Métodos que lista grid e faz pesquisa"
        public DataTable ListaGridMoto()
        {
            /*[marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [corPrimaria_mot], [corSecundaria_mot], [preco_mot], */
            string vsql = "SELECT [id_mot] as Cód, [marca_mot] as Marca, [modelo_mot] as Modelo, [ano_mot] as Ano, [combustivel_mot] as Combustível, [tipoPartida_mot] as Partida, [tipoAlimentacao_mot] as Alimentação, [tipoRefrigeracao_mot] as Refrigeração, [tipoFreio_mot] as Freio, [qtdMarchas_mot] as Marchas, [quilometragem_mot] as Km, [cor_mot] as Cor, [preco_mot] as Preço FROM [ProjetoCtrl].[dbo].[TbMoto]";

            SqlCommand objCmd = null;
            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                SqlDataAdapter adp = new SqlDataAdapter(objCmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        public DataTable Pesquisar(string sql, string param)
        {
            string vsql = sql;

            SqlCommand objCmd = null;

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.Add(new SqlParameter("@valor", param));
                SqlDataAdapter adp = new SqlDataAdapter(objCmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                return dt;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        #endregion

        public List<string> ListaMarcaMoto()
        {
            string vsql = "SELECT [marca_mot] FROM [ProjetoCtrl].[dbo].[TbMarcaMoto]";
            SqlCommand objCmd = null;
            List<string> marca = new List<string>();
            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                SqlDataReader dr = objCmd.ExecuteReader();

                marca.Add("");
                while (dr.Read())
                {
                    marca.Add(dr["marca_mot"].ToString());
                }
                return marca;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
        public List<string> ListaModeloMoto(string marca)
        {
            string vsql = "SELECT [modelo_mot] FROM [ProjetoCtrl].[dbo].[TbModeloMoto] WHERE [marca_mot] = @marca_mot";

            SqlCommand objCmd = null;
            List<string> modelo = new List<string>();
            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.AddWithValue("@marca_mot", marca);
                SqlDataReader dr = objCmd.ExecuteReader();

                while (dr.Read())
                {
                    modelo.Add(dr["modelo_mot"].ToString());
                }
                return modelo;
            }
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
            finally
            {
                BancoDados.fecharConexao();
            }
        }
    }
}
