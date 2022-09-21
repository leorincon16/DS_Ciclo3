using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMecanica.App.Dominio.Entidades
{
    public class Tecnico:Persona
    {
        public int TecnicoId { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaContrato { get; set;}
        public ICollection<Revision> SusRevisiones {get;set;}
    }
}