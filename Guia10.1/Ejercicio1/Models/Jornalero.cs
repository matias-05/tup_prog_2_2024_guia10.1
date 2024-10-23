using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Models
{
    internal class Jornalero : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double ImportePorHora { get; set; }
        public double RetencionesImpositivas { get; set; }
        public Jornalero(int dni, string nombre, int horas,double valorPorHora, double retencion):base(dni,nombre) 
        {
            HorasTrabajadas = horas;
            ImportePorHora = valorPorHora;
            RetencionesImpositivas = retencion;
        }
        public override double CalcularImportaAPagar()
        {
            return HorasTrabajadas * ImportePorHora - RetencionesImpositivas;
        }
        public override string[] GenrarRecibo()
        {
            string[] recibo = new string[5];
            recibo[0] = DNI.ToString();
            recibo[1] = Nombre;
            recibo[2] = HorasTrabajadas.ToString();
            recibo[3] = ImportePorHora.ToString();
            recibo[4] = RetencionesImpositivas.ToString();
            return recibo;
        }
        public override string ToString()
        {
            return $"Dni: {DNI} Nombre: {Nombre}";
        }
    }
}
