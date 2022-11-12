using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;
using Microsoft.VisualBasic;
using System.Data.Entity;
using LibreriaEmpleado;
using LibreriaEmpleado.Models.Derivada;
using System.Runtime.Remoting.Contexts;

namespace WindowsEmpleados.Data
{
    public class DBEmpleadosContext : DbContext
    {
        public DBEmpleadosContext() : base("keyDBEmpleados") { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}
