using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasApi.DTOs
{
    public class ActorPeliculaDetalleDTO
    {
        public int ActorID { get; set; }
        public string Personaje { get; set; }
        public string NombrePersona { get; set; }
    }
}
