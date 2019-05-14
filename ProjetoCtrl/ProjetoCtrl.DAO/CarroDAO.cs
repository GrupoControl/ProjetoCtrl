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
    public class CarroDAO
    {
        public CarroDAO()
        {

        }
        #region "Select no Banco de Dados"
        //public string VerificarBlindagem(int codigo)
        //{
        //    string blindagem = "";
        //    vsql = "SELECT [blindado_car] FROM [ProjetoCtrl].[dbo].[Carro] WHERE [id_car] = @codigo";

        //    SqlCommand objCmd = null;


        //    if (this.Conectar())
        //    {

        //        try
        //        {
        //            objCmd = new SqlCommand(vsql, objCon);
        //            objCmd.Parameters.Add(new SqlParameter("@codigo", codigo));
        //            SqlDataReader leitor = objCmd.ExecuteReader();
        //            while (leitor.Read())
        //            {
        //                blindagem = leitor["blindado_car"].ToString();
        //            }
        //            return blindagem;
        //        }
        //        catch (SqlException sqlerr)
        //        {
        //            throw sqlerr;
        //        }
        //        finally
        //        {
        //            this.Desconectar();
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public string VerificarCombustivel(int codigo)
        //{
        //    string combustivel = "";
        //    vsql = "SELECT [combustivel_car] FROM [ProjetoCtrl].[dbo].[Carro] WHERE [id_car] = @codigo";

        //    SqlCommand objCmd = null;


        //    if (this.Conectar())
        //    {

        //        try
        //        {
        //            objCmd = new SqlCommand(vsql, objCon);
        //            objCmd.Parameters.Add(new SqlParameter("@codigo", codigo));
        //            SqlDataReader leitor = objCmd.ExecuteReader();
        //            while (leitor.Read())
        //            {
        //                combustivel = leitor["combustivel_car"].ToString();
        //            }
        //            return combustivel;
        //        }
        //        catch (SqlException sqlerr)
        //        {
        //            throw sqlerr;
        //        }
        //        finally
        //        {
        //            this.Desconectar();
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        #endregion

        /*MÉTODOS PARA CRUD DE CADASTRO DE CARRO*/
        #region "[CARRO] Métodos de execução de SQL"
        public bool InserirCarro(ArrayList p_arrInserir)
        {
            string vsql = "INSERT INTO [ProjetoCtrl].[dbo].[TbCarro] ([marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]) VALUES (@marca_car, @modelo_car ,@ano_car, @combustivel_car, @quilometragem_car, @cambio_car, @blindado_car, @cor_car, @preco_car)";

            SqlCommand objCmd = null;

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.Add(new SqlParameter("@marca_car", p_arrInserir[0]));
                objCmd.Parameters.Add(new SqlParameter("@modelo_car", p_arrInserir[1]));
                objCmd.Parameters.Add(new SqlParameter("@ano_car", p_arrInserir[2]));
                objCmd.Parameters.Add(new SqlParameter("@combustivel_car", p_arrInserir[3]));
                objCmd.Parameters.Add(new SqlParameter("@quilometragem_car", p_arrInserir[4]));
                objCmd.Parameters.Add(new SqlParameter("@cambio_car", p_arrInserir[5]));
                objCmd.Parameters.Add(new SqlParameter("@blindado_car", p_arrInserir[6]));
                objCmd.Parameters.Add(new SqlParameter("@cor_car", p_arrInserir[7]));
                objCmd.Parameters.Add(new SqlParameter("@preco_car", p_arrInserir[8]));

                objCmd.ExecuteNonQuery();

                /*VALUES (@marca_car, @modelo_car ,@ano_car, @combustivel_car, @quilometragem, @blindado_car, @cor_car, @preco_car)";*/

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
        public bool AtualizarCarro(ArrayList p_arrAtualizar)
        {
            string vsql = "UPDATE [ProjetoCtrl].[dbo].[TbCarro] SET [marca_car] = @marca_car, [modelo_car] = @modelo_car, [ano_car] = @ano_car, [combustivel_car] = @combustivel_car, [quilometragem_car] = @quilometragem_car, [cambio_car] = @cambio_car, [blindado_car] = @blindado_car, [cor_car] = @cor_car, [preco_car] = @preco_car WHERE [id_car] = @id_car";

            SqlCommand objCmd = null;

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.Add(new SqlParameter("@id_car", p_arrAtualizar[0]));
                objCmd.Parameters.Add(new SqlParameter("@marca_car", p_arrAtualizar[1]));
                objCmd.Parameters.Add(new SqlParameter("@modelo_car", p_arrAtualizar[2]));
                objCmd.Parameters.Add(new SqlParameter("@ano_car", p_arrAtualizar[3]));
                objCmd.Parameters.Add(new SqlParameter("@combustivel_car", p_arrAtualizar[4]));
                objCmd.Parameters.Add(new SqlParameter("@quilometragem_car", p_arrAtualizar[5]));
                objCmd.Parameters.Add(new SqlParameter("@cambio_car", p_arrAtualizar[6]));
                objCmd.Parameters.Add(new SqlParameter("@blindado_car", p_arrAtualizar[7]));
                objCmd.Parameters.Add(new SqlParameter("@cor_car", p_arrAtualizar[8]));
                objCmd.Parameters.Add(new SqlParameter("@preco_car", p_arrAtualizar[9]));


                objCmd.ExecuteNonQuery();

                /*VALUES (@marca_car, @modelo_car ,@ano_car, @combustivel_car, @quilometragem, @blindado_car, @cor_car, @preco_car)";*/

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
        public bool DeletarCarro(int id_car)
        {
            string vsql = "DELETE FROM [ProjetoCtrl].[dbo].[TbCarro] WHERE [id_car] = @id_car";

            SqlCommand objCmd = null;
            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.AddWithValue("@id_car", id_car);
                objCmd.ExecuteNonQuery();

                /*VALUES (@marca_car, @modelo_car ,@ano_car, @combustivel_car, @quilometragem, @blindado_car, @cor_car, @preco_car)";*/

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

        #region "[CARRO] Métodos que lista grid e faz pesquisa"
        public DataTable ListaGridCarro()
        {
            string vsql = "SELECT [id_car] as Código, [marca_car] as Marca, [modelo_car] as Modelo, [ano_car] as Ano, [combustivel_car] as Combustível,[quilometragem_car] as Quilometragem, [cambio_car] as Câmbio, [blindado_car] as Blindado, [cor_car] as Cor, [preco_car] as Preço FROM [ProjetoCtrl].[dbo].[TbCarro]";

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
        public List<string> ListaMarcaCar()
        {
            string vsql = "SELECT [marcaCar] FROM [ProjetoCtrl].[dbo].[TbMarcaCar]";

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
                    marca.Add(dr["marcaCar"].ToString());
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
        public List<string> ListaModeloCar(string marca)
        {
            string vsql = "SELECT [modelo] FROM [ProjetoCtrl].[dbo].[TbModeloCar] WHERE [marca] = @marca";

            SqlCommand objCmd = null;
            List<string> modelo = new List<string>();

            try
            {
                SqlConnection objCon = BancoDados.conectarBancoDados();
                SqlCommand cmd = new SqlCommand(vsql, objCon);
                objCmd = new SqlCommand(vsql, objCon);
                objCmd.Parameters.AddWithValue("@marca", marca);
                SqlDataReader dr = objCmd.ExecuteReader();

                while (dr.Read())
                {
                    modelo.Add(dr["modelo"].ToString());
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
