using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMecanica.App.Dominio.Entidades
{
    public class Revision
    {
        public int RevisionId { get; set; }
        public Mantenimiento TipoMantenimiento { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public Estado EstadoAceite { get; set; }
        public Estado EstadoFiltroGasolina { get; set; }
        public Estado EstadoFiltroAire { get; set; }
        public string ObservacionMantenimiento { get; set; }
        public Vehiculo SuVehiculo { get; set; }
        public Tecnico SuTecnico { get; set; }
        public ICollection<Repuesto> SusRepuestos { get; set; }
        public double Valor { get; set; }
    }
}