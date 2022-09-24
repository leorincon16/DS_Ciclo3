using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TallerMecanica.App.Persistencia.AppRepositorios;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Frontend.Pages.ClientesPages
{
    public class ClienteDetalles : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        public Cliente elCliente; 

        public ClienteDetalles()
        {
            _repoCliente = new RepositorioCliente();
        }

        public void OnGet(int idCliente)
        {
            Cliente elCliente = _repoCliente.GetCliente(idCliente);
        }
    }
}