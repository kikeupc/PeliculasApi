﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.Entidades
{
    public class PeliculasGeneros
    {
        public int GeneroID { get; set; }
        public int PeliculaID { get; set; }
        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
