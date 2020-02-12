using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Profissional.Repositorio
{
  
    /// <summary>
    /// Classe responsável por criar a conexão, podendo sempre conectar ou desconectar.
    /// </summary>
    public class Conexao
    {
        static SqlConnection connection;

        static string str = "Data Source=regulus.cotuca.unicamp.br; Initial Catalog=BDApontamento; User ID=BDApontamento;Password=BDApontamento";


        static Conexao()
        {
            connection = new SqlConnection(str);
        }

        static public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            return connection;
        }

        static public void Desconectar()
        {
            
        }

    }
}