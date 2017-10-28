using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSEmpleados" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSEmpleados
    {
       




    }

    [DataContract]
    public class Empleados
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

    public class CompositeType
    {
        
    }
}
