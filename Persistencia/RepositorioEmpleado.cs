using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado //IRepositorioPersona 
    {
        private  readonly AplicacionContext _appContext; // conexion a la base datos
        
        public RepositorioEmpleado(AplicacionContext appContext)
        {
            _appContext = appContext;
        }
        
        public Empleado AddEmpleado(Empleado empleado)
        {            
            var new_Empleado = _appContext.Empleados.Add((Empleado)empleado); 
            _appContext.SaveChanges();
            return new_Empleado.Entity;
        }

        
        public bool DeleteEmpleado(int id)
        {
            var Empleado_eliminado = _appContext.Empleados.FirstOrDefault(p => p.Id == id);
            if(Empleado_eliminado == null)
            return false;
            _appContext.Empleados.Remove(Empleado_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        public Empleado DetailEmpleado(int id_persona)
        {
            return _appContext.Empleados.FirstOrDefault(p => p.Id == id_persona);
        }

      
        public IEnumerable<Empleado> ListEmpleado()
        {
            return _appContext.Empleados;
        }
       
        public Empleado UpdateEmpleado(Empleado empleado)
        {
            //Empleado newEmpleado = (Empleado)empleado;
            var Empleado_encontrado = _appContext.Empleados.FirstOrDefault(p => p.Id == empleado.Id);
            if(Empleado_encontrado != null){
                Empleado_encontrado.Nombre = empleado.Nombre;
                Empleado_encontrado.Cargo = empleado.Cargo;
                Empleado_encontrado.Salario = empleado.Salario;
                Empleado_encontrado.Directivo = empleado.Directivo;
                Empleado_encontrado.CodEmpleado = empleado.CodEmpleado;
                _appContext.SaveChanges();
            }
            return Empleado_encontrado;
        }

    }
}