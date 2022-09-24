using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioRevision:IRepositorioRevision
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioRevision(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioRevision(){
            _appcontext = new ApplicationContext();
        }
        public Revision AddRevision(Revision revision)
        {
            var revisionAdicionado=_appcontext.Revisiones.Add(revision);
            _appcontext.SaveChanges();
            return revisionAdicionado.Entity;
        }

        public bool DeleteRevision(Revision revision)
        {
            var revisionEncontrado =_appcontext.Revisiones.FirstOrDefault(b=>b.RevisionId==revision.RevisionId);
            if(revisionEncontrado==null){
                return false;
            }else{
                _appcontext.Revisiones.Remove(revision);
                return true;
            }
        }

        public IEnumerable<Revision> GetAllRevision()
        {
            return _appcontext.Revisiones;
        }

        public Revision GetRevision(int idRevision)
        {
            return _appcontext.Revisiones.FirstOrDefault(b=>b.RevisionId==idRevision);
        }

        public Revision UpdateRevision(Revision revision)
        {
            var revisionEncontrado =_appcontext.Revisiones.FirstOrDefault(b=>b.RevisionId==revision.RevisionId);
            if (revisionEncontrado != null)
            {
                revisionEncontrado = revision;
                _appcontext.SaveChanges();
                return revisionEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}