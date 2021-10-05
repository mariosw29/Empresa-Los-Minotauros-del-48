using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        //IEnumerable<Empleado> ListPersona();        
        IEnumerable<Empleado> ListEmpleado();
        Empleado AddEmpleado(Empleado empleado);        
        Empleado UpdateEmpleado(Empleado empleado);
        Boolean DeleteEmpleado(int id_persona);
        Empleado DetailEmpleado(int id_persona);  
    }
}