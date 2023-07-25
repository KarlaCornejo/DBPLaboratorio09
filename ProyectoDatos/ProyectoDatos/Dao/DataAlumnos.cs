using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos.Dao
{
    public class DataAlumnos
    {
        private string connectionString;

        public DataAlumnos()
        {
           connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DBEstudiantes.mdf;Integrated Security=True;Connect Timeout=30";
         }

        public void InsertarRegistro(string nombre, string apellidos, string email, string sexo, int codeCiudad, string requerimiento)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "INSERT INTO [dbo].[DataAlumnos] (Code, Nombre, Apellidos, Email, Sexo, CodeCiudad, Requerimiento) " +
                                   "VALUES (50, @Nombre, @Apellidos, @Email, @Sexo, @CodeCiudad, @Requerimiento)";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                        cmd.Parameters.AddWithValue("@CodeCiudad", codeCiudad);
                        cmd.Parameters.AddWithValue("@Requerimiento", requerimiento);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error según tus necesidades
                throw ex;
            }
        }
        
        
        public bool RegistroExiste(string nombre, string apellidos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [dbo].[DataAlumnos] WHERE Nombre = @Nombre AND Apellidos = @Apellidos";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", apellidos);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error según tus necesidades
                throw ex;
            }
        }
   
    
    }
}