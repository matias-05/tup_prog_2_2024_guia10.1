using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Asalariado : Empleado 
    {
        public double Basico { get;  set; }
        public double AportesPrevisionales { get;  set; }
        public Asalariado(int dni, string nombre,double basico,double aportes):base(dni,nombre)
        {
            Basico = basico;
            AportesPrevisionales = aportes;
        }
        public override double CalcularImportaAPagar()
        {
            return Basico - AportesPrevisionales;
        }
        public override string[] GenrarRecibo()
        {
            string[] recibo = new string[4];
            recibo[0] = DNI.ToString();
            recibo[1] = Nombre;
            recibo[2] = Basico.ToString();
            recibo[3] = AportesPrevisionales.ToString();
            return recibo;
        }
        public override string ToString()
        {
            return $"Dni: {DNI} Nombre: {Nombre}";
        }
    }
}
