using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioTecnico:IRepositorioTecnico
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioTecnico(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioTecnico(){
            _appcontext = new ApplicationContext();
        }
        public Tecnico AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado=_appcontext.Tecnicos.Add(tecnico);
            _appcontext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }

        public bool DeleteTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado =_appcontext.Tecnicos.FirstOrDefault(b=>b.PersonaId==tecnico.PersonaId);
            if(tecnicoEncontrado==null){
                return false;
            }else{
                _appcontext.Tecnicos.Remove(tecnico);
                return true;
            }
        }

        public IEnumerable<Tecnico> GetAllTecnico()
        {
            return _appcontext.Tecnicos;
        }

        public Tecnico GetTecnico(int idTecnico)
        {
            return _appcontext.Tecnicos.FirstOrDefault(b=>b.PersonaId==idTecnico);
        }

        public Tecnico UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado =_appcontext.Tecnicos.FirstOrDefault(b=>b.PersonaId==tecnico.PersonaId);
            if (tecnicoEncontrado != null)
            {
                tecnicoEncontrado = tecnico;
                _appcontext.SaveChanges();
                return tecnicoEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}