using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Tickets_BLL;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets
{
    public partial class login : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (usuarioValido())
            {
                Response.Redirect("~/User/UserHome.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('El usuario y/o la contraseña son invalidos')", true);
            }

        }

        #endregion
        #region Metodos
        public bool usuarioValido()
        {
            bool acceso = false;

            UsuarioBLL userBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            

            usuario = userBLL.consultaUsuario(txtEmail.Text,txtPassword.Text);

            if (usuario != null)
            {
                Session["Usuario"] = usuario;
                acceso = true;
            }

            return acceso;
        }
        #endregion

        
    }
}