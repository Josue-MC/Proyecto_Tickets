using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class Cliente_DAL
    {
        sgticketsEntities modelo;

        public Cliente_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public void agregarCliente(Cliente cliente)
        {
            modelo.Cliente.Add(cliente);
            modelo.SaveChanges();
        }

        public List<Cliente> cargarClientes()
        {
            var cliente = from mcliente in modelo.Cliente
                          select mcliente;

            return cliente.ToList();


        }

        public List<Cliente> cargarClientePorCorreo(string pCorreo)
        {
            var cliente = from mcliente in modelo.Cliente
                          where mcliente.email == pCorreo
                          select mcliente;
            return cliente.ToList();
        }

        public int cargarClienteSite()
        {
            var cliente = (from mcliente in modelo.Cliente
                          select mcliente).Count();

            return cliente;
        }
    }
}
