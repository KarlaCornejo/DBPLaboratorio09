﻿using ProyectoDatos;
using ProyectoDatos.Dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Web;

namespace Laboratorio6
{
    public class Service1 : IService1
    {
        public IList<string> GetCiudades_SQL()
        {
            Ciudad c = new Ciudad();
            return c.Query();
        }

        public IList<string> getCiudades()
        {
            IList<string> ciudades = new List<string>();
            ciudades.Add("Arequipa");
            ciudades.Add("Lima");
            ciudades.Add("Tacna");
            return ciudades;
        }

        public void GuardarInformacion(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion)
        {
            string rutaArchivo = HttpContext.Current.Server.MapPath("~/Informacion.txt");

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine($"Nombre: {nombre}");
                writer.WriteLine($"Apellidos: {apellidos}");
                writer.WriteLine($"Sexo: {sexo}");
                writer.WriteLine($"Correo: {correo}");
                writer.WriteLine($"Dirección: {direccion}");
                writer.WriteLine($"Ciudad: {ciudad}");
                writer.WriteLine($"Descripción: {descripcion}");
                writer.WriteLine("----------------------------------");
            }
        }


        public bool GuardarInformacionSQL(String nombre, String apellidos, String sexo, String correo, String direccion, String ciudad, String descripcion)
        {
            DataAlumnos dataAlumnos = new DataAlumnos();
            // Verificar si el registro ya existe antes de insertar
            if (dataAlumnos.RegistroExiste(nombre, apellidos))
            {
                return false;
            }

            // Llamar a la función para insertar el registro
            try
            {
                dataAlumnos.InsertarRegistro(nombre, apellidos, correo, sexo, 2, descripcion);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
