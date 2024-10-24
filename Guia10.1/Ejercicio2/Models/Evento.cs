using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Evento
    {
        List<Persona> personas = new List<Persona>();
        List<Tecnico> tecnicos = new List<Tecnico>();

        public DateTime Fecha { get; private set; }
        public string NombreEvento { get; private set; }
        public Evento(DateTime fecha, string nombre) 
        {
            Fecha = fecha;
            NombreEvento = nombre;
        }
        public void RegistrarExportable(IExportable exp)
        {
            if (exp is Tecnico)
            {
                tecnicos.Add(exp as Tecnico);
            }
            else if (exp is Persona)
            {
                personas.Add(exp as Persona);
            }
        }
        public List<IExportable> VerExportables()
        {
            List<IExportable> exportables = new List<IExportable>();

            foreach (Tecnico tec in tecnicos)
            {
                exportables.Add(tec);
            }

            foreach (Persona per in personas)
            {
                if (per is IExportable) 
                {
                    exportables.Add(per as IExportable);
                }
            }
            return exportables;
        }
        public override string ToString()
        {
            return $"{NombreEvento,15} | {Fecha}";
        }
    }
}
