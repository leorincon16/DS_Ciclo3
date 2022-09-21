using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMecanica.App.Dominio.Entidades
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public Genero Genero { get; set; }
        public string Ciudad { get; set; }
    }
}