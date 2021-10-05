using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private  readonly AplicacionContext _appContext; // conexion a la base datos
        public RepositorioPersona(AplicacionContext appContext)
        {
            _appContext = appContext;
        }

        public Persona AddPersona(Persona persona)
        {
            var new_Persona = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_Persona.Entity;
        }

        public bool DeletePersona(int id_persona)
        {
            var Persona_eliminado = _appContext.Personas.FirstOrDefault(p => p.Id == id_persona);
            if(Persona_eliminado == null)
            return false;
            _appContext.Remove(Persona_eliminado);
            _appContext.SaveChanges();
            return true;
        }

        public Persona DetailPersona(int id_persona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == id_persona);
        }

        public IEnumerable<Persona> ListPersona()
        {
            return _appContext.Personas.AsNoTracking();
        }

        public Persona UpdatePersona(Persona persona)
        {
            var Persona_encontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if(Persona_encontrado != null){
                Persona_encontrado.Nombre = persona.Nombre; 
                Persona_encontrado.Apellido = persona.Apellido; 
                Persona_encontrado.Cedula = persona.Cedula;
                Persona_encontrado.Email = persona.Email;
                _appContext.SaveChanges();
            }
            return Persona_encontrado;
        }
    }
}