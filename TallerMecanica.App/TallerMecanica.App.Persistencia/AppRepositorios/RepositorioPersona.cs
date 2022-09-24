using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona:IRepositorioPersona
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioPersona(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioPersona(){
            _appcontext = new ApplicationContext();
        }
        public Persona AddPersona(Persona persona)
        {
            var personaAdicionado=_appcontext.Personas.Add(persona);
            _appcontext.SaveChanges();
            return personaAdicionado.Entity;
        }

        public bool DeletePersona(Persona persona)
        {
            var personaEncontrado =_appcontext.Personas.FirstOrDefault(b=>b.PersonaId==persona.PersonaId);
            if(personaEncontrado==null){
                return false;
            }else{
                _appcontext.Personas.Remove(persona);
                return true;
            }
        }

        public IEnumerable<Persona> GetAllPersona()
        {
            return _appcontext.Personas;
        }

        public Persona GetPersona(int idPersona)
        {
            return _appcontext.Personas.FirstOrDefault(b=>b.PersonaId==idPersona);
        }

        public Persona UpdatePersona(Persona persona)
        {
            var personaEncontrado =_appcontext.Personas.FirstOrDefault(b=>b.PersonaId==persona.PersonaId);
            if (personaEncontrado != null)
            {
                personaEncontrado = persona;
                _appcontext.SaveChanges();
                return personaEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}