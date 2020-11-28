﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.Entidades
{
    public class PeliculasActores
    {
        public int ActorID { get; set; }
        public int PeliculaID { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }
        public Actor Actor { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
