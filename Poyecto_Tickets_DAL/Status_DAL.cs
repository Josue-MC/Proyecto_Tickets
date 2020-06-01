using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class Status_DAL
    {
        sgticketsEntities modelo;

        public Status_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public List<Status> CargarStatus()
        {
            var status = from mstatus in modelo.Status
                         select mstatus;
            return status.ToList();
        }
    }
}
