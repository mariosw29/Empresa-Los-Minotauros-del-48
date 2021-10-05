using System;

namespace Dominio
{
    public class Empleado : Persona
    {
        
        //public int Id { get; set; }      
        public string Cargo { get; set; }

        public int Salario { get; set; }

        public string Directivo { get; set; }

        public int CodEmpleado { get; set; }        

    }
}