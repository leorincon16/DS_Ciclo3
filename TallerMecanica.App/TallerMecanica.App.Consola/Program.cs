using System;
using TallerMecanica.App.Dominio.Entidades;
using TallerMecanica.App.Persistencia.AppRepositorios;

namespace TallerMecanica.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new ApplicationContext());
        private static IRepositorioRepuesto _repoRepuesto = new RepositorioRepuesto(new ApplicationContext());
        private static IRepositorioRevision _repoRevision = new RepositorioRevision(new ApplicationContext());
        private static IRepositorioTecnico _repoTecnico = new RepositorioTecnico(new ApplicationContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new ApplicationContext());

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            AddCliente();
        }
        private static void AddCliente(){
            var cliente = new Cliente{
                Nombres="Jose",
                Apellidos="Perez",
                FechaIngreso=new DateTime(2022,9,21)
            };
            _repoCliente.AddCliente(cliente);
        }
        // private static void ReadCliente(){
        //     var cliente = new 
        // }


    }
}
