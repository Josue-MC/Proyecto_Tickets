using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets.Tipo
{
    public partial class tipo_u : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            int ID_Tipo = int.Parse(Request.QueryString["pID_Tipo"]);
            cargarTipoPorID(ID_Tipo);
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            
        }

        protected void btnEditarTipo_Click(object sender, EventArgs e)
        {
            editarTipo();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Categoría editada Exitosamente.')", true);
        }


        public void editarTipo()
        {
            Tipo_BLL tipoBLL = new Tipo_BLL();
            Poyecto_Tickets_DAL.Tipo tipo = new Poyecto_Tickets_DAL.Tipo();

            tipo.ID_Tipo = int.Parse(lblID_Tipo.Text);
            tipo.Nombre = txtNombre.Text;
            tipo.Descripcion = txtDescripcion.Text;

            tipoBLL.EditarTipo(tipo);
        }


        public void cargarTipoPorID(int pID_Tipo)
        {
            Tipo_BLL tipoBLL = new Tipo_BLL();
            Poyecto_Tickets_DAL.Tipo tipo = new Poyecto_Tickets_DAL.Tipo();

            tipo = tipoBLL.cargarTiposPorID(pID_Tipo);

            lblID_Tipo.Text = tipo.ID_Tipo.ToString();
            txtNombre.Text = tipo.Nombre;
            txtDescripcion.Text = tipo.Descripcion;


        }
    }
}