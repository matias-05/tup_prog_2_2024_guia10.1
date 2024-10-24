using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Persona
    {
        protected int dni;
        protected string nombre;
        public string DNI
        {
            get { return dni.ToString(); }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
    }
}
