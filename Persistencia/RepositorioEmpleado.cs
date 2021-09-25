using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioPersona 
    {
        private  readonly AplicacionContext _appContext; // conexion a la base datos

        public RepositorioEmpleado()
        {
        }

        public RepositorioEmpleado(AplicacionContext appContext)
        {
            _appContext = appContext;
        }
        
        public Persona AddPersona(Persona empleado)
        {
            var new_Empleado = _appContext.Empleados.Add((Empleado)empleado); 
            _appContext.SaveChanges();
            return new_Empleado.Entity;
        }
     
        public bool DeletePersona(int id_persona)
        {
            var Empleado_eliminado = _appContext.Empleados.FirstOrDefault(p => p.Id == id_persona);
            if(Empleado_eliminado == null)
            return false;
            _appContext.Empleados.Remove(Empleado_eliminado);
            _appContext.SaveChanges();
            return true;
        }


        public Empleado DetailEmpleado(int id_empleado)
        {
            return _appContext.Empleados.FirstOrDefault(p => p.Id == id_empleado);
        }

        public Persona DetailPersona(int id_persona)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> ListPersona()
        {
            return _appContext.Empleados;
        }

        public Persona UpdatePersona(Persona empleado)
        {
            Empleado newEmpleado = (Empleado)empleado;
            var Empleado_encontrado = _appContext.Empleados.FirstOrDefault(p => p.Id == newEmpleado.Id);
            if(Empleado_encontrado != null){
                Empleado_encontrado.Cargo = newEmpleado.Cargo;
                Empleado_encontrado.Salario = newEmpleado.Salario;
                Empleado_encontrado.Directivo = newEmpleado.Directivo;
                Empleado_encontrado.CodEmpleado = newEmpleado.CodEmpleado;
                _appContext.SaveChanges();
            }
            return Empleado_encontrado;
        }
        
    }
}