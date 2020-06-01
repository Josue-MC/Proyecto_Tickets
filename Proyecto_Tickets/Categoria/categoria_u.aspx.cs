using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets.Categoria
{
    public partial class categoria_u : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ID_Categoria = int.Parse(Request.QueryString["pID_Categoria"]);
                cargarCategoriaPorID(ID_Categoria);
                lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            

            
        }

        protected void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            editarCategoria();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Producto/Servicio editado Exitosamente.')", true);
        }

        public void editarCategoria()
        {
            Categoria_BLL categoriaBLL = new Categoria_BLL();
            Poyecto_Tickets_DAL.Categoria categoria = new Poyecto_Tickets_DAL.Categoria();

            categoria.ID_Categoria = int.Parse(lblID_Categoria.Text);
            categoria.nombre = txtNombre.Text;
            categoria.descripcion = txtDescripcion.Text;

            categoriaBLL.EditarCategoria(categoria);
        }

        public void cargarCategoriaPorID(int pID_Categoria)
        {
            Categoria_BLL categoriaBLL = new Categoria_BLL();
            Poyecto_Tickets_DAL.Categoria categoria = new Poyecto_Tickets_DAL.Categoria();

            categoria = categoriaBLL.cargarCategoriasPorID(pID_Categoria);

            lblID_Categoria.Text = categoria.ID_Categoria.ToString();
            txtNombre.Text = categoria.nombre;
            txtDescripcion.Text = categoria.descripcion;


        }
    }
}