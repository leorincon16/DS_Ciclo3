using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMecanica.App.Dominio.Entidades;

namespace TallerMecanica.App.Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly ApplicationContext _appcontext;

        public RepositorioCliente(ApplicationContext appContext){
            _appcontext = appContext;
        }
        public RepositorioCliente(){
            _appcontext = new ApplicationContext();
        }
        public Cliente AddCliente(Cliente cliente)
        {
            var clienteAdicionado=_appcontext.Clientes.Add(cliente);
            _appcontext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        public bool DeleteCliente(Cliente cliente)
        {
            var clienteEncontrado =_appcontext.Clientes.FirstOrDefault(b=>b.PersonaId==cliente.PersonaId);
            if(clienteEncontrado==null){
                return false;
            }else{
                _appcontext.Clientes.Remove(cliente);
                return true;
            }
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _appcontext.Clientes;
        }

        public Cliente GetCliente(int clienteId)
        {
            return _appcontext.Clientes.FirstOrDefault(b=>b.PersonaId==clienteId);
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado =_appcontext.Clientes.FirstOrDefault(b=>b.PersonaId==cliente.PersonaId);
            if (clienteEncontrado != null)
            {
                clienteEncontrado = cliente;
                _appcontext.SaveChanges();
                return clienteEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}