using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioCargo : IRepositorioCargo
    {
        private  readonly AplicacionContext _appContext; // conexion a la base datos
        public RepositorioCargo(AplicacionContext appContext)
        {
            _appContext = appContext;
        }

        public Cargo AddCargo(Cargo cargo)
        {
            var new_Cargo = _appContext.Cargos.Add(cargo);
            _appContext.SaveChanges();
            return new_Cargo.Entity;
        }
        
        public bool DeleteCargo(int id_cargo)
        {
            var Cargo_eliminado = _appContext.Cargos.FirstOrDefault(p => p.Id == id_cargo);
            if(Cargo_eliminado == null)
            return false;
            _appContext.Remove(Cargo_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        public Cargo DetailCargo(int id_cargo)
        {
            return _appContext.Cargos.FirstOrDefault(p => p.Id == id_cargo);
        }

        public IEnumerable<Cargo> ListCargo()
        {
            return _appContext.Cargos;
        }

        public Cargo UpdateCargo(Cargo cargo)
        {
            var Cargo_encontrado = _appContext.Cargos.FirstOrDefault(p => p.Id == cargo.Id);
            if(Cargo_encontrado != null){
                Cargo_encontrado.Nombre_cargo = cargo.Nombre_cargo;
                Cargo_encontrado.Nivel = cargo.Nivel;               
                _appContext.SaveChanges();
            }
            return Cargo_encontrado;
        }

    }
}