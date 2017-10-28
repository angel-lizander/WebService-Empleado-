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