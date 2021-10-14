using MisClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_HelloWorld_WebForms_UI.Models
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Evento asociado a la pulsación del boton "Enviar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            clsPersona yo; 
            string nombre = txtNombre.Text;
            if (!String.IsNullOrEmpty(nombre))
            {
                yo =new clsPersona(nombre);
                lblMensaje.Text = $"Hola {yo.Nombre}";
                lblError.Text = "";
            }
            else 
            {
                lblError.Text = "El nombre no puede estar vacio";
                lblMensaje.Text = "";
            }

        }
    }
}
