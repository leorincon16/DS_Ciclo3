using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMecanica.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public string VehiculoId{get;set;}
        public string Marca{get;set;}
        public string Color{get;set;}
        public string Tipo{get;set;}
        public string Modelo{get;set;}
        public string Placa { get; set; }
        public int ClienteId {get;set;}
        public Cliente SuPropietario {get;set;}
        public ICollection<Revision> SusRevisiones{get;set;}
    }
}