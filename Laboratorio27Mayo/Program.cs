using Laboratorio27Mayo.clases;
using System.Numerics;

//Agregar a empleados un adicional llamado sueldo

GestorEmpleados empleados = new GestorEmpleados("c:\\tmp\\Empleados.db");
empleados.CrearTabla();



//empleados.AgregarEmpleado(new Empleado(1, "John", "Doe", 30, "Gerente",2000.10));
//empleados.AgregarEmpleado(new Empleado(2, "Steven", "Quintana", 19, "Jefe Estatal", 6000.10));
//empleados.AgregarEmpleado(new Empleado(2, "Gaby", "noc", 18, "Limpieza", 4000.20));

empleados.ObtenerEmpleados();

empleados.ObtenerEmpleados().ForEach(e => Console.WriteLine($"{ e.Nombre} - {e.Apellido} - {e.Edad} - {e.Cargo} - {e.Sueldo}"));
