using System;
using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioCargo
    {
        IEnumerable<Cargo> ListCargo();
        Cargo AddCargo(Cargo cargo);        
        Cargo UpdateCargo(Cargo cargo);        
        Boolean DeleteCargo(int id_cargo);        
        Cargo DetailCargo(int id_cargo);  
    }
}