using System;
using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioProveedor
    {
        IEnumerable<Proveedor> ListProveedor();
        Proveedor AddProveedor(Proveedor proveedor);        
        Proveedor UpdateProveedor(Proveedor proveedor);        
        Boolean DeleteProveedor(int id_Proveedor);        
        Empresa DetailProveedor(int id_Proveedor); 
    }
}