using ProyectoDatos.Dao;
using System.Collections.Generic;
using System;

namespace ProyectoDatos
{
    class DBConeccion
    {
        public static void Main(String[] args)
        {
            DBConeccion conn = new DBConeccion();
            conn.query();
            conn.InsertarRegistro();
        }

        private void query()
        {
            Ciudad c = new Ciudad();
            IList<string> list = c.Query();
            if (list == null)
            {
                Console.WriteLine("No data");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        private void InsertarRegistro()
        {
            DataAlumnos dataAlumnos = new DataAlumnos();

            // Ejemplo de cómo insertar un registro
            string nombre = "Juan";
            string apellidos = "Pérez";
            string email = "juan@example.com";
            string sexo = "M";
            int codeCiudad = 1; // Supongamos que ya conoces el codeCiudad
            string requerimiento = "Información adicional";

            try
            {
                dataAlumnos.InsertarRegistro(nombre, apellidos, email, sexo, codeCiudad, requerimiento);
                Console.WriteLine("Registro insertado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el registro: " + ex.Message);
            }
        }
    }
}
