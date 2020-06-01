using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Cliente_BLL
    {
        public List<Cliente> cargarClientes()
        {
            Cliente_DAL clienteDAL = new Cliente_DAL();
            return clienteDAL.cargarClientes();
        }

        public void agregarCliente(Cliente cliente)
        {
            Cliente_DAL clienteDAL = new Cliente_DAL();
            List<Cliente> listCliente = new List<Cliente>();

            listCliente = clienteDAL.cargarClientePorCorreo(cliente.email);
            if (listCliente != null)
            {
                throw new Exception("El correo ya se encuentra asociado.");
            }
            else
            {
                clienteDAL.agregarCliente(cliente);
            }
                

            
            
        }


        public List<Cliente> cargarClientePorCorreo(string pCorreo)
        {
            Cliente_DAL clienteDAL = new Cliente_DAL();
            return clienteDAL.cargarClientePorCorreo(pCorreo);

            
        }

        public int cargarClienteSite()
        {
            Cliente_DAL clienteDAL = new Cliente_DAL();
            return clienteDAL.cargarClienteSite();
        }
    }
}
