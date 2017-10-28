using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFEmpleados
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
    List<Empleador> getListEmpleador();
    }

   /* public class Empleados
    {
    public string Conomina { get; set; }
    public string Tipodocumento { get; set; }
    public string Documento { get; set; }
    public string Nombre { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string Sexo { get; set; }
    public string Fnacimiento { get; set; }
    public string Sueldoneto { get; set; }
    public string Descuento { get; set; }
    public string Sueldosecundario { get; set; }
}

    public <Lista>(Conomina, )*/
   


    
}
