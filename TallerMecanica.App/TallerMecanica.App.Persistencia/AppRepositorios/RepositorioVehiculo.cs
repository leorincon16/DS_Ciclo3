using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioVehiculo(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioVehiculo(){
            _appcontext = new ApplicationContext();
        }
        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAdicionado=_appcontext.Vehiculos.Add(vehiculo);
            _appcontext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }

        public bool DeleteVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado =_appcontext.Vehiculos.FirstOrDefault(b=>b.VehiculoId==vehiculo.VehiculoId);
            if(vehiculoEncontrado==null){
                return false;
            }else{
                _appcontext.Vehiculos.Remove(vehiculo);
                return true;
            }
        }

        public IEnumerable<Vehiculo> GetAllVehiculo()
        {
            return _appcontext.Vehiculos;
        }

        public Vehiculo GetVehiculo(int idVehiculo)
        {
            return _appcontext.Vehiculos.FirstOrDefault(b=>b.VehiculoId==idVehiculo);
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado =_appcontext.Vehiculos.FirstOrDefault(b=>b.VehiculoId==vehiculo.VehiculoId);
            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado = vehiculo;
                _appcontext.SaveChanges();
                return vehiculoEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}