﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clases
{
    public class Serializador
    {
        public string Path { get; set; }

        public Serializador(string path)
        {
            Path = path;
        }
    }
}
