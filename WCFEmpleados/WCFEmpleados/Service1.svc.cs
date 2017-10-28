using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEmpleados
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Empleador> getListEmpleador()
        {
           
            List<Empleador> lstEmpleado = new List<Empleador>();
            lstEmpleado.Add(new Empleador("1", "1", "001 - 08868822", "Angel", "Valenzuela", "Evangelista", "M", "23 / 03 / 96", "2000", "2000", "2000"));
            lstEmpleado.Add(new Empleador("1", "1", "001 - 08868822", "Angel", "Valenzuela", "Evangelista", "M", "23 / 03 / 96", "2000", "2000", "2000"));

            return lstEmpleado;
        }
    }
}
