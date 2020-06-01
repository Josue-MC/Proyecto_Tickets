using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class Categoria_DAL
    {
        sgticketsEntities modelo;

        public Categoria_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            modelo.Categoria.Add(categoria);
            modelo.SaveChanges();
        }

        public List<Categoria> cargarCategorias()
        {
            var categoria = from mcategoria in modelo.Categoria
                             select mcategoria;

            return categoria.ToList();

            
        }

        public Categoria cargarCategoriasPorID(int pID_Categoria)
        {
            var categoria = (from mcategoria in modelo.Categoria
                            where mcategoria.ID_Categoria == pID_Categoria
                            select mcategoria).FirstOrDefault();

            return categoria;


        }

        public void editarCategoria(Categoria pCategoria)
        {
            var categoria = (from mcategoria in modelo.Categoria
                            where mcategoria.ID_Categoria == pCategoria.ID_Categoria
                            select mcategoria).FirstOrDefault();
            categoria.nombre = pCategoria.nombre;
            categoria.descripcion = pCategoria.descripcion;

            modelo.SaveChanges();
        }

        public int cargarCategoriasSite()
        {
            var categoria = (from mcategoria in modelo.Categoria
                             select mcategoria).Count();

            return categoria;
        }

        public string cargarCategoriaPorId(int pID_Categoria)
        {
            var categoria = (from mcategoria in modelo.Categoria
                             where mcategoria.ID_Categoria == pID_Categoria
                             select mcategoria.nombre).FirstOrDefault();

            return categoria;

        }
    }
}
