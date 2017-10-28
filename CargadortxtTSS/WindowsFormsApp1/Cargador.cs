using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cargador : Form
    {
        public Cargador()
        {
            InitializeComponent();
        }

        public void Cargador_Load(object sender, EventArgs e)
        {
            var employees = new List<WSEmpleados.Empleador>();

            using (var client = new WSEmpleados.Service1Client())
            {
                 employees = client.getListEmpleador().ToList();
            }

            //filter Example

            var result = employees.Where(emp => emp.Conomina == "2").ToList();


          
            var dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Código de nómina", typeof(string));
            dt.Columns.Add("Tipo de documento", typeof(string));
            dt.Columns.Add("Documento", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Sexo", typeof(string));
            dt.Columns.Add("Primer Apellido", typeof(string));
            dt.Columns.Add("Segundo Apellido", typeof(string));
            dt.Columns.Add("Fecha de nacimiento", typeof(DateTime));
            dt.Columns.Add("Sueldo Neto", typeof(string));
            dt.Columns.Add("Descuento", typeof(string));
            dt.Columns.Add("Sueldo secundario", typeof(string));

            foreach (var item in employees)
            {
                DataRow dr = dt.NewRow();
                dr["Código de nómina"] = item.Conomina;
                dr["Tipo de documento"] = item.Tipodocumento;
                dr["Documento"] = item.Documento;
                dr["Nombre"] = item.Nombre;
                dr["Sexo"] = item.Sexo;
                dr["Primer apellido"] = item.Apellido1;
                dr["Segundo Apellido"] = item.Apellido2;
                dr["Fecha de nacimiento"] = item.Fnacimiento;
                dr["Sueldo neto"] = item.Sueldoneto;
                dr["Descuento"] = item.Descuento;
                dr["Sueldo secundario"] = item.Sueldosecundario;
                dt.Rows.Add(dr);
            }
            

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


                }

}
        }

       

