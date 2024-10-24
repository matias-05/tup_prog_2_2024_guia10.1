using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btAlta_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtFecha.Value;
            string nombre = tbNombre.Text;
            Evento nuevo = new Evento(fecha, nombre);
            lbLista.Items.Add(nuevo);
            tbNombre.Clear();
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            Evento evento = lbLista.SelectedItem as Evento;

            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Importacion de Tecnicos/Expositores";
                ofd.Filter = "Archivos csv |*.csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    sr.ReadLine();

                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');

                        IExportable importado = null;
                        string tipo = campos[0];
                        if (tipo == "Tecnico")
                        {
                            importado = new Tecnico();
                        }
                        else if (tipo == "Expositor")
                        {
                            importado = new Expositor();
                        }
                        importado.Leer(campos);
                        evento.RegistrarExportable(importado);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error de importación");
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
        }
    }
}

