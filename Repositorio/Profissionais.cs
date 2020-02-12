using Profissional.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Profissional.Repositorio
{
    public class Profissionais
    {

        public List<ProfissionalModel> GetTodosProfissionais()
        {
            {
                SqlConnection con = null;
                List<ProfissionalModel> listadeProfissionais = new List<ProfissionalModel>();
                try
                {
                    con = Conexao.Conectar();
                    SqlCommand cmd = new SqlCommand("select * from Profissional  ", con);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read() == true)
                    {
                        int id = rdr.GetInt32(0);
                        string nome = rdr.GetString(1);
                        ProfissionalModel profissional = new ProfissionalModel(id, nome);

                        listadeProfissionais.Add(profissional);

                    }
                }
                catch
                {
                    throw new Exception("Erro");
                }
                finally
                {
                    con.Close();
                }

                return listadeProfissionais;
            }

        }

        public void InsertProfissional(ProfissionalModel pm)
        {
            {

                SqlConnection con = null;

                try
                {
                    con = Conexao.Conectar();
                    SqlCommand cmd = new SqlCommand(" Insert Into Profissional values(@id,@nome)",con);
                    cmd.Parameters.AddWithValue("@id", pm.Id);
                    cmd.Parameters.AddWithValue("@nome", pm.Nome);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e) {

                }

            }
        }
        public void DeleteProfissional(ProfissionalModel)

    }
}
