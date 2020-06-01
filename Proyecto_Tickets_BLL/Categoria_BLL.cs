using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Categoria_BLL
    {
        public List<Categoria> cargarCategorias()
        {
            Categoria_DAL categoria = new Categoria_DAL();
            return categoria.cargarCategorias();
        }

        public Categoria cargarCategoriasPorID(int pID_Categoria)
        {
            Categoria_DAL categoria = new Categoria_DAL();
            return categoria.cargarCategoriasPorID(pID_Categoria);
        }

        public void AgregarCategoria(Categoria categoria)
        {
            Categoria_DAL categoriaDAL = new Categoria_DAL();
            categoriaDAL.AgregarCategoria(categoria);
        }
       
        public void EditarCategoria(Categoria pCategoria)
        {
            Categoria_DAL categoriaDAL = new Categoria_DAL();
            categoriaDAL.editarCategoria(pCategoria);
        }

        public int cargarCategoriasSite()
        {
            Categoria_DAL categoriaDAL = new Categoria_DAL();
            return categoriaDAL.cargarCategoriasSite();
        }

        public string cargarCategoriaPorId(int pID_Categoria)
        {
            Categoria_DAL categoriaDAL = new Categoria_DAL();
            return categoriaDAL.cargarCategoriaPorId(pID_Categoria);
        }
    }
}
