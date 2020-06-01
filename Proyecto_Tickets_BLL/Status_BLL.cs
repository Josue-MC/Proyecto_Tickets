using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Status_BLL
    {
        public List<Status> cargarStatus()
        {
            Status_DAL statusDAL = new Status_DAL();
            
            return statusDAL.CargarStatus();
        }
    }
}
