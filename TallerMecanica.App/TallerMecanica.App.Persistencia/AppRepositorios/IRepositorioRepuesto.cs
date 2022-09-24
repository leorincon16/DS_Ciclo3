using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRepuesto
    {
        IEnumerable<Repuesto> GetAllRepuesto();
        Repuesto AddRepuesto(Repuesto repuesto);
        Repuesto UpdateRepuesto(Repuesto repuesto);
        Boolean DeleteRepuesto(Repuesto repuesto);
        Repuesto GetRepuesto(int idRepuesto);
    }
}