//using AplicacionWebParaDBP.ServiceReference1;
using AplicacionWebParaDBP.ServiciosLaboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebParaDBP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                addDropDownCiudadItem();
                deleteSessions();
                // Lógica para cargar los datos iniciales, si es necesario
            }
        }

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            // Lógica para manejar el evento ButtonEnviar_Click
            string nombre = this.nombre.Text;
            string apellidos = this.apellidos.Text;
            string sexo = string.Empty;
            if (this.sexo.SelectedValue == "M")
            {
                sexo = "Masculino";
            }
            else if (this.sexo.SelectedValue == "F")
            {
                sexo = "Femenino";
            }
            string correo = this.correo.Text;
            string direccion = this.direccion.Text;
            string ciudad = this.ciudadDropdown.SelectedValue;
            string descripcion = this.descripcion.Text;

            // Mostrar los valores recibidos en el contenedor
            this.lblNombre.InnerText = nombre;
            this.lblApellidos.InnerText = apellidos;
            this.lblSexo.InnerText = sexo;
            this.lblCorreo.InnerText = correo;
            this.lblDireccion.InnerText = direccion;
            this.lblCiudad.InnerText = ciudad;
            this.lblDescripcion.InnerText = descripcion;

            // Mostrar el contenedor con los valores recibidos
            this.resultContainer.Visible = true;
            
            // Llamar a la función para guardar la información
            //GuardarInformacion(nombre, apellidos, sexo, correo, direccion, ciudad, descripcion);
            createSesion(nombre, apellidos, sexo, direccion, ciudad);
            createSesionCookies(nombre, apellidos, sexo, direccion, ciudad);
            // Limpiar los campos del formulario
            LimpiarCampos();
            Response.Redirect("Auxiliar.aspx");
        }

        private void LimpiarCampos()
        {
            this.nombre.Text = string.Empty;
            this.apellidos.Text = string.Empty;
            this.sexo.SelectedValue = string.Empty;
            this.correo.Text = string.Empty;
            this.direccion.Text = string.Empty;
            //this.ciudadDropdown.SelectedValue = string.Empty;
            this.descripcion.Text = string.Empty;
        }

        private void createSesion(String nombre,String apellido, String sexo, String direccion, String ciudad)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellido;
            Session["Sexo"] = sexo;
            Session["Direccion"] = direccion;
            Session["Ciudad"] = ciudad;
        }




        private void createSesionCookies(String nombre, String apellido, String sexo, String direccion, String ciudad)
        {
            // Guardar información en cookies
            HttpCookie cookieNombre = new HttpCookie("Nombre", nombre);
            HttpCookie cookieApellido = new HttpCookie("Apellido", apellido);
            HttpCookie cookieSexo = new HttpCookie("Sexo", sexo);
            HttpCookie cookieDireccion = new HttpCookie("Direccion", direccion);
            HttpCookie cookieCiudad = new HttpCookie("Ciudad", ciudad);

            // Establecer la duración de las cookies (por ejemplo, 1 día)
            cookieNombre.Expires = DateTime.Now.AddDays(1);
            cookieApellido.Expires = DateTime.Now.AddDays(1);
            cookieSexo.Expires = DateTime.Now.AddDays(1);
            cookieDireccion.Expires = DateTime.Now.AddDays(1);
            cookieCiudad.Expires = DateTime.Now.AddDays(1);

            // Agregar las cookies a la respuesta del servidor
            Response.Cookies.Add(cookieNombre);
            Response.Cookies.Add(cookieApellido);
            Response.Cookies.Add(cookieSexo);
            Response.Cookies.Add(cookieDireccion);
            Response.Cookies.Add(cookieCiudad);
        }

        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }
        private void GuardarInformacion(string nombre, string apellidos, string sexo, string correo, string direccion, string ciudad, string descripcion)
        {
            // Crear el cliente del servicio
            Service1Client client = new Service1Client();

            try
            {
                // Llamar al método del servicio para guardar la información
                //client.GuardarInformacion(nombre, apellidos, sexo, correo, direccion, ciudad, descripcion);
            }
            finally
            {
                // Cerrar el cliente del servicio en caso de excepción
                if (client.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    client.Abort();
                }
                else
                {
                    client.Close();
                }
            }
        }

        private String[] serviceCall()
        {
            Service1Client client = new Service1Client();
            String[] ciudades = client.GetCiudades_SQL();

            return ciudades;

        }

        protected void addDropDownCiudadItem()
        {
            String[] ciudades = serviceCall();

            Array.Sort(ciudades);
            ciudadDropdown.Items.Add("Selecciona una opcion");

            for (int i = 0; i < ciudades.Length; i++)
            {
                string s = ciudades[i];
                ciudadDropdown.Items.Add(s);
            }
        }



    }
}
