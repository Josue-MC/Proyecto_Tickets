using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class UsuarioDAL
    {
        sgticketsEntities modelo;

        public UsuarioDAL()
        {
            modelo = new sgticketsEntities();
        }

        public Usuario ConsultaUsuario(string email, string contraseña)
        {
            var usuario = (from mUsuario in modelo.Usuario
                           where mUsuario.email == email && mUsuario.contraseña == contraseña
                           select mUsuario).FirstOrDefault();

            return usuario;
        }

    }
}
