using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFEmpleados
{
    [DataContract]
    public class Empleador
    {
        [DataMember]
        public string Conomina { get; set; }
        [DataMember]
        public string Tipodocumento { get; set; }
        [DataMember]
        public string Documento { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido1 { get; set; }
        [DataMember]
        public string Apellido2 { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public string Fnacimiento { get; set; }
        [DataMember]
        public string Sueldoneto { get; set; }
        [DataMember]
        public string Descuento { get; set; }
        [DataMember]
        public string Sueldosecundario { get; set; }


        public Empleador(string Conomina, string Tipodocumento, string Documento, string Nombre, string Apellido1, string Apellido2, String Sexo, string Fnacimiento, string Sueldoneto, string Descuento, string Sueldosecundario)
        {
            this.Conomina = Conomina;
            this.Tipodocumento = Tipodocumento;
            this.Documento = Documento;
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Sexo = Sexo;
            this.Fnacimiento = Fnacimiento;
            this.Sueldoneto = Sueldoneto;
            this.Descuento = Descuento;
            this.Sueldosecundario = Sueldosecundario;
        }
    }
}