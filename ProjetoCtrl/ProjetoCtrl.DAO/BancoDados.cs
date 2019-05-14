using System;
using System.Collections.Generic;
//using para ArrayList
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Criando using pro banco de dados
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCtrl.DAO
{
    public class BancoDados
    {
        private const string _strCon = @"Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string vsql = string.Empty;
 
        private static SqlConnection objCon = null;


        public static SqlConnection conectarBancoDados()
        {
            //Vamos criar a conexão
            objCon = new SqlConnection(_strCon);

            // a conexão foi feita com sucesso?
            try
            {
                //abre a conexãoe a devolve ao chamador do método
                objCon.Open();
                Console.WriteLine("--->> Conexão OK ---");
            }
            catch (SqlException erroSQL)
            {
                objCon = null;
                Console.WriteLine("--->> Conexão Error: " + erroSQL);
                //mostra o erro que ocorreu no campo
            }
            finally
            {
                Console.WriteLine("--->> Fique atento ---");
            }
            return objCon;
        }

        public static void fecharConexao()
        {
            if (objCon != null)
            {
                objCon.Close();
            }
        }
    }
   
}
