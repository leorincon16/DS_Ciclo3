using System;
using TallerMecanica.App.Dominio.Entidades;
using TallerMecanica.App.Persistencia.AppRepositorios;

namespace TallerMecanica.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new ApplicationContext());
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

    }
}
