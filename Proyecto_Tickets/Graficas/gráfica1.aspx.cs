using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Tickets_BLL;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets.Graficas
{
    public partial class gráfica1 : System.Web.UI.Page
    {
        int[] barras = new int[3];
        string[] nombres = { "Desarrollo", "Terminado", "Cancelado" };

        static int catet = cargarCategorias();  //Variable que obtiene el tamaño de los arreglos.
        int[] barras1 = new int[catet];
        string[] nombres1 = new string[catet];

        static int tipot = cargarTipos();
        int[] barras2 = new int[tipot];
        string[] nombres2 = new string[tipot];

        static int nivelt = cargarNiveles();
        int[] barras3 = new int[nivelt];
        string[] nombres3 = new string[nivelt];



        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            datosGrafica();
        }


        public int cargarTicketsGrafica(int pNivel, int pStatus)
        {
            Ticket_BLL ticket = new Ticket_BLL();
            return ticket.cargarTicketGrafica(pNivel, pStatus);


        }

        public int cargarTicketsGrafica1(int pNivel, int pCategoria)
        {
            Ticket_BLL ticket = new Ticket_BLL();
            return ticket.cargarTicketGrafica1(pNivel, pCategoria);


        }

        public int cargarTicketsGrafica2(int pNivel, int pTipo)
        {
            Ticket_BLL ticket = new Ticket_BLL();
            return ticket.cargarTicketGrafica2(pNivel, pTipo);


        }

        public int cargarTicketGrafica3(int pNivel1)
        {
            Ticket_BLL ticket = new Ticket_BLL();
            return ticket.cargarTicketGrafica3(pNivel1);
        }

        public static int cargarCategorias()
        {
            Categoria_BLL categoria = new Categoria_BLL();
            return categoria.cargarCategoriasSite();
        }


        public string cargarCategoriaPorId(int pID_Categoria)
        {
            Categoria_BLL categoria = new Categoria_BLL();
            return categoria.cargarCategoriaPorId(pID_Categoria);
        }

        public static int cargarTipos()
        {
            Tipo_BLL tipo = new Tipo_BLL();
            return tipo.cargarTiposSite();
        }

        public string cargarTipoPorId(int pID_Tipo)
        {
            Tipo_BLL tipo = new Tipo_BLL();
            return tipo.cargarTipoPorId(pID_Tipo);
        }

        public static int cargarNiveles()
        {
            Nivel_Soporte_BLL nivel = new Nivel_Soporte_BLL();
            return nivel.cargarNiveles();
        }

        public string cargarNivelNombre(int ID_Nivel)
        {
            Nivel_Soporte_BLL nivel = new Nivel_Soporte_BLL();
            return nivel.cargarNivelNombre(ID_Nivel);

        }

        public void datosGrafica()
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            int pNivel = usuario.nivel_soporte;
            int pNivel1 = 1;
            int pStatus = 1;
            int pCategoria = 8;
            int pID_Categoria = 8;
            int pTipo = 6;
            int pID_Tipo = 6;
            int ID_Nivel = 1;


            //Grafica Status
            for (int i = 0; i < 3; i++)
            {
                barras[i] = cargarTicketsGrafica(pNivel, pStatus);
                pStatus++;
            }

            
            //Gráfica Categoria
            for (int i = 0; i < catet; i++)
            {
                barras1[i] = cargarTicketsGrafica1(pNivel, pCategoria);
                pCategoria++;
            }

            for (int i = 0; i < catet; i++)
            {
                nombres1[i] = cargarCategoriaPorId(pID_Categoria);
                pID_Categoria++;
                
            }

            
            //Gráfica Tipos
            for (int i = 0; i < tipot; i++)
            {
                barras2[i] = cargarTicketsGrafica2(pNivel, pTipo);
                pTipo++;
            }

            for (int i = 0; i < tipot; i++)
            {
                nombres2[i] = cargarTipoPorId(pID_Tipo);
                pID_Tipo++;

            }

            //Gráfica Niveles
            for (int i = 0; i < nivelt; i++)
            {
                barras3[i] = cargarTicketGrafica3(pNivel1);
                pNivel1++;
            }

            for (int i = 0; i < nivelt; i++)
            {
                nombres3[i] = cargarNivelNombre(ID_Nivel);
                ID_Nivel++;

            }



            ChartEstado.Series["Series1"].Points.DataBindXY(nombres,barras);
            ChartCategoria.Series["Series2"].Points.DataBindXY(nombres1, barras1);
            ChartTipo.Series["Series3"].Points.DataBindXY(nombres2, barras2);
            ChartNivel.Series["Series4"].Points.DataBindXY(nombres3, barras3);


        }

    }
}