using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TallerMecanica.App.Persistencia.AppRepositorios;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Frontend.Pages
{
    public class ClientesModel : PageModel
    {
        public readonly IRepositorioCliente _repoClientes;
        public IEnumerable<Cliente> listaClientes;
        public ClientesModel()
        {
            _repoClientes= new RepositorioCliente();         
        }

        public void OnGet()
        {
            listaClientes= _repoClientes.GetAllClientes();
        }
    }
}
