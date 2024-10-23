using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<Empleado> empleados = new List<Empleado>();
        private void btImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Importación de empleados";
            o.Filter = "Fichero csv|*csv";
            if (o.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(o.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();
                    sr.ReadLine();

                    while(sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();

                        string[] campos = linea.Split(';');
                        string tipo = campos[0];
                        int dni = Convert.ToInt32(campos[1]);
                        string nombre = campos[2];

                        Empleado empl = null;

                        if (tipo == "Asalariado")
                        {
                            double basico = Convert.ToDouble(campos[3]);
                            double aportes = Convert.ToDouble(campos[4]);
                            empl = new Asalariado(dni, nombre, basico, aportes);
                        }
                        else if (tipo == "Jornalero")
                        {
                            int horas = Convert.ToInt32(campos[3]);
                            double valorPorHora = Convert.ToDouble(campos[4]);
                            double retencion = Convert.ToDouble(campos[5]);
                            empl = new Jornalero(dni, nombre, horas, valorPorHora, retencion);
                        }

                        empleados.Sort();
                        int idx = empleados.BinarySearch(empl);

                        if (idx >= 0)
                        {
                            
                            if (empl is Asalariado)
                            {
                                ((Asalariado)empleados[idx]).Basico = ((Asalariado)empl).Basico;
                            }
                            else if (empl is Jornalero)
                            {
                                ((Jornalero)empleados[idx]).ImportePorHora = ((Jornalero)empl).ImportePorHora;
                            }
                        }
                        else
                        {
                            empleados.Add(empl);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error al importar");
                }
                finally
                {
                    if (fs != null) fs.Close();
                    if (sr != null) sr.Close();
                }
            }
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            lbEmpleados.Items.Clear();
            lbEmpleados.Items.AddRange(empleados.ToArray());
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "exportar.csv";
            s.Title = "Exportación de empleados";
            s.Filter = "Fichero csv|*csv";
            if (s.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(s.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Tipo: Asalariado; DNI; Nombre; Básico; Aportes provisionales");
                    sw.WriteLine("Tipo: Jornalero; DNI; Nombre; Horas Trabajadas; Importe Por Hora; Retenciones");

                    foreach (Empleado em in empleados)
                    {
                        string linea = "";

                        if (em is Asalariado)
                        {
                            Asalariado asalariado = (Asalariado)em;
                            linea = $"Asalariado;{asalariado.DNI};{asalariado.Nombre};{asalariado.Basico:f2},{asalariado.AportesPrevisionales}";
                        }
                        else if (em is Jornalero)
                        {
                            Jornalero jornalero = (Jornalero)em;
                            linea = $"Jornelero;{jornalero.DNI};{jornalero.Nombre};{jornalero.HorasTrabajadas:f2},{jornalero.RetencionesImpositivas}";
                        }
                        sw.WriteLine(linea);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error al importar");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
