using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRevision
    {
        IEnumerable<Revision> GetAllRevision();
        Revision AddRevision(Revision revision);
        Revision UpdateRevision(Revision revision);
        Boolean DeleteRevision(Revision revision);
        Revision GetRevision(int idRevision);
    }
}