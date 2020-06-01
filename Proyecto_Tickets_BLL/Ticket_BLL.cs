using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Ticket_BLL
    {
        public void agregarTicket(Ticket paramticket)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            ticketDal.agregarTicket(paramticket);


        }

        public void editarTicket(Ticket pTicket)
        {

            Ticket_DAL ticketDal = new Ticket_DAL();
            Ticket ticket = new Ticket();

            ticket = ticketDal.cargarTicket(pTicket.ID_Ticket);

            if (pTicket.nivel_Soporte >= ticket.nivel_Soporte)
            {
                ticketDal.editarTicket(pTicket);
            }
            else
            {
                throw new Exception("El nivel de soporte es inferior.");
            }



        }

        public Ticket cargarTicket(int ID_Ticket)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicket(ID_Ticket);
        }

        public List<object> CargarTicketsPorNivel(int pNivel)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.CargarTicketsPorNivel(pNivel);
        }

        public List<object> CargarTicketsPorEstados(int pNivel, int pStatus, int pTipo, int pCategoria)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.CargarTicketsPorEstados(pNivel, pStatus, pTipo, pCategoria);
        }

        public List<object> CargarTicketsPorID(int pNivel, int pID_Ticket)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.CargarTicketsPorID(pNivel, pID_Ticket);
        }

        public List<object> CargarTicketsPorIDEstado(int pNivel, int pID_Ticket, int pEstado)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.CargarTicketsPorIDEstado(pNivel, pID_Ticket, pEstado);
        }

        public List<object> CargarTicketsPorEstado(int pNivel, int pEstado)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.CargarTicketsPorEstado(pNivel, pEstado);
        }

        public void eliminarTicket(int ID_Ticket)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            ticketDal.eliminarTicket(ID_Ticket);
        }

        public int cargarTicketSite(int pNivel)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicketSite(pNivel);
        }

        public int cargarTicketGrafica(int pNivel, int pStatus)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicketGrafica(pNivel, pStatus);
        }

        public int cargarTicketGrafica1(int pNivel, int pCategoria)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicketGrafica1(pNivel, pCategoria);
        }

        public int cargarTicketGrafica2(int pNivel, int pTipo)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicketGrafica2(pNivel, pTipo);
        }

        public int cargarTicketGrafica3(int pNivel1)
        {
            Ticket_DAL ticketDal = new Ticket_DAL();
            return ticketDal.cargarTicketGrafica3(pNivel1);
        }
    }
}
