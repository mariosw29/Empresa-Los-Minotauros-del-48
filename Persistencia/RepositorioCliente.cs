using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioCliente : IRepositorioPersona
    {
        private readonly AplicacionContext _appContext; // conexion a la base datos
        public RepositorioCliente(AplicacionContext appContext)
        {
            _appContext = appContext;
        }

        
        public Persona AddPersona(Persona cliente)
        {
            var new_Cliente = _appContext.Clientes.Add((Cliente)cliente); 
            _appContext.SaveChanges();
            return new_Cliente.Entity;
        }

        public bool DeletePersona(int id_persona)
        {
            var Cliente_eliminado = _appContext.Clientes.FirstOrDefault(p => p.Id == id_persona);
            if(Cliente_eliminado == null)
            return false;
            _appContext.Clientes.Remove(Cliente_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        /*public Cliente DetailCliente(int id_cliente)
        {
            return _appContext.Clientes.FirstOrDefault(p => p.Id == id_cliente);
        }*/

        public Persona DetailPersona(int id_persona)
        {
            throw new NotImplementedException();
        }

        /*public IEnumerable<Cliente> ListCliente()
        {
            return _appContext.Clientes;
        }*/

        public IEnumerable<Persona> ListPersona()
        {
            throw new NotImplementedException();
        }

        
        public Persona UpdatePersona(Persona cliente)
        {
            Cliente newCliente = (Cliente)cliente;
            var Cliente_encontrado = _appContext.Clientes.FirstOrDefault(p => p.Id == newCliente.Id);
            if(Cliente_encontrado != null){
                Cliente_encontrado.Direccion = newCliente.Direccion;
                Cliente_encontrado.Telefono = newCliente.Telefono;
                
                _appContext.SaveChanges();
            }
            return Cliente_encontrado;
        }
    }
}