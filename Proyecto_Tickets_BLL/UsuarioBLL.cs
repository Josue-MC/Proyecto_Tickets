using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class UsuarioBLL
    {
        public Usuario consultaUsuario(string email, string contraseña)
        {
            UsuarioDAL usuario = new UsuarioDAL();
            return usuario.ConsultaUsuario(email, contraseña);
        }
    }
}
