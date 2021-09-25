using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AplicacionContext _appContext; // conexion a la base datos
        public RepositorioEmpresa(AplicacionContext appContext)
        {
            _appContext = appContext;
        }
        
        public Empresa AddEmpresa(Empresa empresa)
        {
            var new_Empresa = _appContext.Empresas.Add(empresa);
            _appContext.SaveChanges();
            return new_Empresa.Entity;
        }
        
        public bool DeleteEmpresa(int id_empresa)
        {
            var Empresa_eliminado = _appContext.Empresas.FirstOrDefault(p => p.Id == id_empresa);
            if(Empresa_eliminado == null)
            return false;
            _appContext.Remove(Empresa_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        public Empresa DetailEmpresa(int id_empresa)
        {
            return _appContext.Empresas.FirstOrDefault(p => p.Id == id_empresa);
        }

        public IEnumerable<Empresa> ListEmpresa()
        {
            return _appContext.Empresas;
        }

        public Empresa UpdateEmpresa(Empresa empresa)
        {
            var Empresa_encontrado = _appContext.Empresas.FirstOrDefault(p => p.Id == empresa.Id);
            if(Empresa_encontrado != null){
                Empresa_encontrado.Razon_social = empresa.Razon_social;
                Empresa_encontrado.Nit = empresa.Nit;
                Empresa_encontrado.Id_Proveedor = empresa.Id_Proveedor;                
                _appContext.SaveChanges();
            }
            return Empresa_encontrado;
        }
    }
}