using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebParaDBP
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
        }


        public static Dictionary<string, string> ObtenerInformacionDesdeServidor()
        {
            Dictionary<string, string> datos = new Dictionary<string, string>
            {
                { "Nombre", "Karla Veronica" },
                { "Apellidos", "Cornejo Pari" },
                { "Sexo", "Femenino" },
                { "Direccion", "Calle Ideal 101" },
                { "Ciudad", "Arequipa" }
            };

            return datos;
        }

        private void loadSession()
        {
            String nombre = (String)(Session["Nombre"]);
            String apellido = (String)(Session["Apellido"]);
            String sexo = (String)(Session["Sexo"]);
            String direccion = (String)(Session["Direccion"]);
            String ciudad = (String)(Session["Ciudad"]);
            // Asignacion de la informacion a los campos HTML respectivos
            //lblUsuario.Text = "Enviado por Sesion: ";
            lblNombre.Text = nombre;
            lblApellidos.Text = apellido;
            lblSexo.Text = sexo;
            lblCiudad.Text = ciudad;
            lblDireccion.Text = direccion;
        }

        protected void btnMostrarCookies_Click(object sender, EventArgs e)
        {
            // Mostrar el contenido de las cookies en los Labels
            if (Request.Cookies["Nombre"] != null)
                Label1.Text = Request.Cookies["Nombre"].Value;

            if (Request.Cookies["Apellido"] != null)
                Label2.Text = Request.Cookies["Apellido"].Value;

            if (Request.Cookies["Sexo"] != null)
                Label3.Text = Request.Cookies["Sexo"].Value;

            if (Request.Cookies["Direccion"] != null)
                Label4.Text = Request.Cookies["Direccion"].Value;

            if (Request.Cookies["Ciudad"] != null)
                Label5.Text = Request.Cookies["Ciudad"].Value;
        }

        [System.Web.Services.WebMethod]
        public static string getInformacion(string valor)
        {
            return "Desde el servidor se recibio: " + valor;
        }
        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }
    }
}