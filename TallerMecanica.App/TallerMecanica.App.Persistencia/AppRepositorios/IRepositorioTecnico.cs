using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnico> GetAllTecnico();
        Tecnico AddTecnico(Tecnico tecnico);
        Tecnico UpdateTecnico(Tecnico tecnico);
        Boolean DeleteTecnico(Tecnico tecnico);
        Tecnico GetTecnico(int idTecnico);
    }
}