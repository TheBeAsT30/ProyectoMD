using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BASEDATOS
{
    public class CDUser
    {
        public List<Users> Listar()
        {
            List<Users> lista = new List<Users>();
            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Id, Name, Last_name, NUser, Email, Password FROM users";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Users()
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Name = dataReader["Name"].ToString(),
                                Last_name = dataReader["Last_name"].ToString(),
                                NUser = dataReader["NUser"].ToString(),
                                Email = dataReader["Email"].ToString(),
                                Password = dataReader["Password"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Users>();
                }
            }
            return lista;
        }
    }
}
