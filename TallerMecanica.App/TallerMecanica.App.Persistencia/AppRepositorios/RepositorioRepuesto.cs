using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioRepuesto:IRepositorioRepuesto
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioRepuesto(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioRepuesto(){
            _appcontext = new ApplicationContext();
        }
        public Repuesto AddRepuesto(Repuesto repuesto)
        {
            var repuestoAdicionado=_appcontext.Repuestos.Add(repuesto);
            _appcontext.SaveChanges();
            return repuestoAdicionado.Entity;
        }

        public bool DeleteRepuesto(Repuesto repuesto)
        {
            var repuestoEncontrado =_appcontext.Repuestos.FirstOrDefault(b=>b.RepuestoId==repuesto.RepuestoId);
            if(repuestoEncontrado==null){
                return false;
            }else{
                _appcontext.Repuestos.Remove(repuesto);
                return true;
            }
        }

        public IEnumerable<Repuesto> GetAllRepuesto()
        {
            return _appcontext.Repuestos;
        }

        public Repuesto GetRepuesto(int idRepuesto)
        {
            return _appcontext.Repuestos.FirstOrDefault(b=>b.RepuestoId==idRepuesto);
        }

        public Repuesto UpdateRepuesto(Repuesto repuesto)
        {
            var repuestoEncontrado =_appcontext.Repuestos.FirstOrDefault(b=>b.RepuestoId==repuesto.RepuestoId);
            if (repuestoEncontrado != null)
            {
                repuestoEncontrado = repuesto;
                _appcontext.SaveChanges();
                return repuestoEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}