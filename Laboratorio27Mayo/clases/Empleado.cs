using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio27Mayo.clases
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Sueldo { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }

        public Empleado(int id, string nombre, string apellido, int edad, string cargo, double sueldo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Cargo = cargo;
            this.Sueldo = sueldo;
        }
        public override string ToString()
        {
            return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo} Sueldo: {Sueldo}";
        }
    }
}
