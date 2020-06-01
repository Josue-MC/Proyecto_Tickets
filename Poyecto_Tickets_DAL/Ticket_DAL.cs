using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Poyecto_Tickets_DAL
{
    public class Ticket_DAL
    {
        sgticketsEntities modelo;

        public Ticket_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public void agregarTicket(Ticket ticket)
        {
            modelo.Ticket.Add(ticket);
            modelo.SaveChanges();

        }

        public void editarTicket(Ticket pTicket)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where mTicket.ID_Ticket == pTicket.ID_Ticket
                          select mTicket).FirstOrDefault();

            ticket.titulo = pTicket.titulo;
            ticket.descripcion = pTicket.descripcion;
            ticket.fecha_creacion = pTicket.fecha_creacion;
            ticket.fecha_termino = pTicket.fecha_termino;
            ticket.categoria = pTicket.categoria;
            ticket.tipo = pTicket.tipo;
            ticket.ID_Usuario = pTicket.ID_Usuario;
            ticket.ID_Asignado = pTicket.ID_Asignado;
            ticket.nivel_Soporte = pTicket.nivel_Soporte;
            ticket.status = pTicket.status;
            ticket.solucion = pTicket.solucion;

            modelo.SaveChanges();
        }

        public Ticket cargarTicket(int ID_Ticket)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where mTicket.ID_Ticket == ID_Ticket
                          select mTicket).FirstOrDefault();
            return ticket;
        }




        public List<object> CargarTicketsPorNivel(int pNivel)
        {
            var tickets = from mtickets in modelo.Ticket
                          where mtickets.nivel_Soporte == pNivel
                          orderby mtickets.status ascending, mtickets.ID_Ticket descending
                          select new
                          {
                              ID_Ticket = mtickets.ID_Ticket,
                              titulo = mtickets.titulo,
                              nombreStatus = mtickets.Status1.Nombre,
                              nombreCategoria = mtickets.Categoria1.nombre,
                              nombreTipo = mtickets.Tipo1.Nombre,
                              fecha_creacion = mtickets.fecha_creacion,
                              fecha_termino = mtickets.fecha_termino,
                              nombreID_Asignado = mtickets.Usuario.nombre,
                              ID_Usuario = mtickets.ID_Usuario

                          };
            return tickets.AsEnumerable<object>().ToList();

        }



        public List<object> CargarTicketsPorEstados(int pNivel, int pStatus, int pTipo, int pCategoria)
        {
            var tickets = from mtickets in modelo.Ticket
                          where (mtickets.nivel_Soporte == pNivel) && (mtickets.status == pStatus || mtickets.tipo == pTipo || mtickets.categoria == pCategoria)
                          orderby mtickets.status ascending
                          select new
                          {
                              ID_Ticket = mtickets.ID_Ticket,
                              titulo = mtickets.titulo,
                              nombreStatus = mtickets.Status1.Nombre,
                              nombreCategoria = mtickets.Categoria1.nombre,
                              nombreTipo = mtickets.Tipo1.Nombre,
                              fecha_creacion = mtickets.fecha_creacion,
                              fecha_termino = mtickets.fecha_termino,
                              nombreID_Asignado = mtickets.Usuario.nombre,
                              ID_Usuario = mtickets.ID_Usuario

                          };
            return tickets.AsEnumerable<object>().ToList();

        }

        public List<object> CargarTicketsPorID(int pNivel, int pID_Ticket)
        {
            var tickets = from mtickets in modelo.Ticket
                          where (mtickets.nivel_Soporte == pNivel) && (mtickets.ID_Ticket == pID_Ticket)
                          orderby mtickets.ID_Ticket descending
                          select new
                          {
                              ID_Ticket = mtickets.ID_Ticket,
                              titulo = mtickets.titulo,
                              nombreStatus = mtickets.Status1.Nombre,
                              nombreCategoria = mtickets.Categoria1.nombre,
                              nombreTipo = mtickets.Tipo1.Nombre,
                              fecha_creacion = mtickets.fecha_creacion,
                              fecha_termino = mtickets.fecha_termino,
                              nombreID_Asignado = mtickets.Usuario.nombre,
                              ID_Usuario = mtickets.ID_Usuario

                          };
            return tickets.AsEnumerable<object>().ToList();

        }

        public List<object> CargarTicketsPorIDEstado(int pNivel, int pID_Ticket, int pEstado)
        {
            var tickets = from mtickets in modelo.Ticket
                          where (mtickets.nivel_Soporte == pNivel) && (mtickets.ID_Ticket == pID_Ticket) && (mtickets.status == pEstado)
                          orderby mtickets.ID_Ticket descending
                          select new
                          {
                              ID_Ticket = mtickets.ID_Ticket,
                              titulo = mtickets.titulo,
                              nombreStatus = mtickets.Status1.Nombre,
                              nombreCategoria = mtickets.Categoria1.nombre,
                              nombreTipo = mtickets.Tipo1.Nombre,
                              fecha_creacion = mtickets.fecha_creacion,
                              fecha_termino = mtickets.fecha_termino,
                              nombreID_Asignado = mtickets.Usuario.nombre,
                              ID_Usuario = mtickets.ID_Usuario

                          };
            return tickets.AsEnumerable<object>().ToList();

        }

        public List<object> CargarTicketsPorEstado(int pNivel, int pEstado)
        {
            var tickets = from mtickets in modelo.Ticket
                          where (mtickets.nivel_Soporte == pNivel) && (mtickets.status == pEstado)
                          orderby mtickets.ID_Ticket descending
                          select new
                          {
                              ID_Ticket = mtickets.ID_Ticket,
                              titulo = mtickets.titulo,
                              nombreStatus = mtickets.Status1.Nombre,
                              nombreCategoria = mtickets.Categoria1.nombre,
                              nombreTipo = mtickets.Tipo1.Nombre,
                              fecha_creacion = mtickets.fecha_creacion,
                              fecha_termino = mtickets.fecha_termino,
                              nombreID_Asignado = mtickets.Usuario.nombre,
                              ID_Usuario = mtickets.ID_Usuario

                          };
            return tickets.AsEnumerable<object>().ToList();

        }

        public void eliminarTicket(int ID_Ticket)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where mTicket.ID_Ticket == ID_Ticket
                          select mTicket).FirstOrDefault();

            modelo.Ticket.Remove(ticket);
            modelo.SaveChanges();
        }

        public int cargarTicketSite(int pNivel)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where (mTicket.nivel_Soporte == pNivel) && (mTicket.status == 1)
                          select mTicket).Count();
            return ticket;
        }

        public int cargarTicketGrafica(int pNivel, int pStatus)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where (mTicket.nivel_Soporte == pNivel) && (mTicket.status == pStatus)
                          select mTicket).Count();
            return ticket;
        }

        public int cargarTicketGrafica1(int pNivel, int pCategoria)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where (mTicket.nivel_Soporte == pNivel) && (mTicket.categoria == pCategoria)
                          select mTicket).Count();
            return ticket;
        }

        public int cargarTicketGrafica2(int pNivel, int pTipo)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where (mTicket.nivel_Soporte == pNivel) && (mTicket.tipo == pTipo)
                          select mTicket).Count();

            return ticket;
        }

        public int cargarTicketGrafica3(int pNivel1)
        {
            var ticket = (from mTicket in modelo.Ticket
                          where mTicket.nivel_Soporte == pNivel1
                          select mTicket).Count();

            return ticket;
        }

    }
}
