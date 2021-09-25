using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly AplicacionContext _appContext; // conexion a la base datos
        public RepositorioProveedor(AplicacionContext appContext)
        {
            _appContext = appContext;
        }
        public Proveedor AddProveedor(Proveedor proveedor)
        {
            var new_Proveedor = _appContext.Proveedors.Add(proveedor);
            _appContext.SaveChanges();
            return new_Proveedor.Entity;
        }

        public bool DeleteProveedor(int id_Proveedor)
        {
            var Proveedor_eliminado = _appContext.Proveedors.FirstOrDefault(p => p.Id == id_Proveedor);
            if(Proveedor_eliminado == null)
            return false;
            _appContext.Remove(Proveedor_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        public Proveedor DetailProveedor(int id_Proveedor)
        {
            return _appContext.Proveedors.FirstOrDefault(p => p.Id == id_Proveedor);
            
        }

        public IEnumerable<Proveedor> ListProveedor()
        {
             return _appContext.Proveedors;
        }

        public Proveedor UpdateProveedor(Proveedor proveedor)
        {
            var Proveedor_encontrado = _appContext.Proveedors.FirstOrDefault(p => p.Id == proveedor.Id);
            if(Proveedor_encontrado != null){
                Proveedor_encontrado.Id_Proveedor = proveedor.Id_Proveedor;
                Proveedor_encontrado.Nit = proveedor.Nit;
                Proveedor_encontrado.Nombre_prov = proveedor.Nombre_prov;
                Proveedor_encontrado.Id_prod = proveedor.Id_prod;                
                _appContext.SaveChanges();
            }
            return Proveedor_encontrado;
        }

        Empresa IRepositorioProveedor.DetailProveedor(int id_Proveedor)
        {
            throw new NotImplementedException();
        }
    }
}