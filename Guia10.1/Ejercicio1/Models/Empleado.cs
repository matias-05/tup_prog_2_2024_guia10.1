using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Empleado: IComparable
    {
        public int DNI { get;  set; }
        public string Nombre { get;  set; }
        public Empleado(int dni, string nombre) 
        {
            DNI = dni;
            Nombre = nombre;
        }
        public abstract double CalcularImportaAPagar();
        public abstract string[] GenrarRecibo();
        public int CompareTo(object obj)
        {
            if (obj == null && obj is Empleado)
            {
                return this.DNI.CompareTo(((Empleado)obj).DNI);
            }
            return 1;
        }
    }
}
