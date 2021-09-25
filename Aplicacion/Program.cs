using System;
using Dominio;
using Persistencia;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new  RepositorioPersona(new Persistencia.AplicacionContext());
        private static IRepositorioPersona _repoEmpleado = new  RepositorioEmpleado(new Persistencia.AplicacionContext());
        private static IRepositorioPersona _repoCliente = new  RepositorioCliente(new Persistencia.AplicacionContext());        
        private static IRepositorioCargo _repoCargo = new  RepositorioCargo(new Persistencia.AplicacionContext());
        private static IRepositorioEmpresa _repoEmpresa = new  RepositorioEmpresa(new Persistencia.AplicacionContext());
        private static IRepositorioProveedor _repoProveedor = new  RepositorioProveedor(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            // Nuevo Empleado
            addPersonaE();
            Console.WriteLine("Empleado Insertado");
            //deletePersonaE();
            //Console.WriteLine("Empleado Eliminado"); 
            //updatePersonaE();
            //Console.WriteLine("Empleado Actualizado"); 

            //addPersonaC();
            //Console.WriteLine("Cliente Insertado");
            //deletePersonaC();
            //Console.WriteLine("Cliente Eliminado");
            //updatePersonaC();
            //Console.WriteLine("Cliente Actualizado"); 

            //updatePersona();
            //Console.WriteLine("Persona Actualizada datos Basicos");
           
            //addCargo();        
            //Console.WriteLine("Cargo Insertado"); 
            //updateCargo();
            //Console.WriteLine("Cargo Actualizado"); 
            //deleteCargo();
            //Console.WriteLine("Cargo Eliminado");

            //addEmpresa();        
            //Console.WriteLine("Empresa Insertada"); 
            //deleteEmpresa();
            //Console.WriteLine("Empresa Eliminado");
            //updateEmpresa();
            //Console.WriteLine("Empresa Actualizada");

            //addProveedor();        
            //Console.WriteLine("Proveedor Insertado"); 
            //deleteProveedor();
            //Console.WriteLine("Proveedor Eliminado");
            //updateProveedor();
            //Console.WriteLine("Proveedor Actualizado");

        }
        // *************************** CRUD PERSONA EMPLEADO *************************************

        private static void addPersonaE(){
            var persona = new Empleado{
                Nombre = "Pepito",
                Apellido = "Perez-Davila",
                Cedula = 325000,
                Email = "peito@gmail.com",
                Cargo = "jefe-bodega",
                Salario = 65400,
                Directivo = "SI",
                CodEmpleado = 1007

            };
            _repoEmpleado.AddPersona(persona); 
        }

      
        private static void deletePersonaE(){
            _repoEmpleado.DeletePersona(5);
        }

        private static void updatePersonaE(){
            var persona = new Empleado{
                Id = 1,                
                Cargo = "Gerente",
                Salario = 6500199,
                Directivo = "SI",
                CodEmpleado = 1005
            };
            _repoEmpleado.UpdatePersona(persona);
        }
        //************* fin Persona ********************

        // *************************** CRUD Persona Cliente *************************************
        
        private static void addPersonaC(){
            var personac = new Cliente{
                Nombre = "Johanna",
                Apellido = "Mosquera",
                Cedula = 3704000,
                Email = "johamat85@gmail.com",
                Direccion = "Mz-15-Cs15",
                Telefono = 31520544

            };
            _repoCliente.AddPersona(personac); 
        }

      
        private static void deletePersonaC(){
            _repoCliente.DeletePersona(4);
        }

        private static void updatePersonaC(){
            var personac = new Cliente{
                Id = 5,                
                Direccion = "Cra-19-Av-Americas",
                Telefono = 7372927
            };
            _repoCliente.UpdatePersona(personac);
        }
        
        //************* fin cliente********************
        
        
        //**************** PERSONA ACTUALIZAR DATOS BASICO DE LA HERENCIA ****************
        private static void updatePersona(){
            var persona = new Persona{
                Id = 1,                
                Nombre = "Juliana-S",
                Apellido = "Agreda-Agreda",
                Cedula = 10250041,
                Email = "JuliAgr@gamil.com"                
            };
            _repoPersona.UpdatePersona(persona);
        }
        
        
        // *************************** CRUD Cargo *************************************

        private static void addCargo(){
            var cargo = new Cargo{
                Nombre_cargo = "Subgente",
                Nivel = 3
            };
            _repoCargo.AddCargo(cargo);
        }

        private static void deleteCargo(){
            _repoCargo.DeleteCargo(3);
        }

        private static void updateCargo(){
            var cargo = new Cargo{
                Id = 2,
                Nombre_cargo = "Directivo",
                Nivel = 2               
            };
            _repoCargo.UpdateCargo(cargo);
        }
        //************* fin Cargo********************
        
        // *************************** CRUD Empresa *************************************

        private static void addEmpresa(){
            var empresa = new Empresa{
                Razon_social = 4,
                Nit = "80000-2",
                Id_Proveedor = 101
            };
            _repoEmpresa.AddEmpresa(empresa);
        }

        private static void deleteEmpresa(){
            _repoEmpresa.DeleteEmpresa(1);
        }

        private static void updateEmpresa(){
            var empresa = new Empresa{
                Id = 1,
                Razon_social = 2,
                Nit = "54656-1",
                Id_Proveedor = 102                
            };
            _repoEmpresa.UpdateEmpresa(empresa);
        }
        //************* fin Empresa ********************

        // *************************** CRUD Proveedor *************************************

        private static void addProveedor(){
            var proveedor = new Proveedor{
                Id_Proveedor = 101,
                Nit = "854100-9",
                Nombre_prov = "Exito",
                Id_prod = 901
                
            };
            _repoProveedor.AddProveedor(proveedor);
        }

        private static void deleteProveedor(){
            _repoProveedor.DeleteProveedor(1);
        }

        private static void updateProveedor(){
            var proveedor = new Proveedor{
                Id = 1,
                Id_Proveedor = 101,
                Nit = "854100-5",
                Nombre_prov = "Exito-Pasto",
                Id_prod = 900                
            };
            _repoProveedor.UpdateProveedor(proveedor);
        }
        //************* fin Proveedor ********************

    }
}