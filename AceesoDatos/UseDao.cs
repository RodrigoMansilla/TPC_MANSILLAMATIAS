using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;

namespace AceesoDatos
{
    public class UseDao:ConnectionToSql
    {
        public bool Login(string user, string pass)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from USUARIOS where LoginName = @user and Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.id = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Apellido = reader.GetString(4);
                            UserLoginCache.Cargo = reader.GetString(5);
                            UserLoginCache.Correo = reader.GetString(6);
                        }
                        return true;
                        
                    }
                    else
                        return false; 
                }

            }
        }
    }
}
