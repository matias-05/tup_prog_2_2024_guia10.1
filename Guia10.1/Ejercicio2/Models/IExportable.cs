﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal interface IExportable
    {
         void Leer(string[] linea);
         string Escribir();
    }
}
