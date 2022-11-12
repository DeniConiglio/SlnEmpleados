using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleado.Models.Derivada;

namespace PresentacionWindows
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado1 = new Empleado() { Legajo = "221", Id = 1, Nombre = "Alejandro", Apellido = "Lopez" };
            Empleado empleado2 = new Empleado() { Legajo = "332", Id = 2, Nombre = "Alejo", Apellido = "Gonzales" };
            Empleado empleado3 = new Empleado() { Legajo = "113", Id = 3, Nombre = "pepe", Apellido = "Perez" };
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);


            Departamento departamento = new Departamento() { Id = 12, Nombre = "juan", ListaEmpleados = empleados };
            gridEmpleados.DataSource = departamento.ListaEmpleados;
        }
    }

       
 }

