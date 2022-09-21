using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMecanica.App.Dominio.Entidades
{
    public class Cliente:Persona
    {
        public int ClienteId {get;set; }
        public ICollection<Vehiculo> Vehiculos {get;set;}

    }
}