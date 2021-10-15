using System;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;
using MascotaFeliz.app.Persistencia.AppRepositorios;

namespace MascotaFeliz.app.Console
{
    class Program
    {
        //private static IRepositorioMedico _repoMedico= new RepositorioMedico();
        private static IRepositorioTipoAnimal _repoTipoAnimal= new RepositorioTipoAnimal();
        private static IRepositorioCentroVeterinario _repoCentroVeterinario= new RepositorioCentroVeterinario();

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            AddDatos();
            //DeleteDato();
            GetTodo();
            //GetMedico(1);
        }

        private static void GetTodo(){
           var todos= _repoTipoAnimal.GetAllTiposAnimales();
           foreach(var tipoAnimal in todos){
               System.Console.WriteLine(tipoAnimal.Id);
               System.Console.WriteLine(tipoAnimal.Nombre);
           }
        }

        private static void GetDato(){
            var tipoAnimal = _repoTipoAnimal.GetTipoAnimal(1);
            System.Console.WriteLine(tipoAnimal.Nombre);
        }

        private static void DeleteDato(){
            _repoTipoAnimal.DeleteTipoAnimal(3);
        }

        private static void AddDatos(){
            var tipoAnimal1 = new TipoAnimal("Perro");  
            var tipoAnimal2 = new TipoAnimal("Gato"); 
            var tipoAnimal3 = new TipoAnimal("Ave"); 
            _repoTipoAnimal.AddTipoAnimal(tipoAnimal1);
            _repoTipoAnimal.AddTipoAnimal(tipoAnimal2);
            _repoTipoAnimal.AddTipoAnimal(tipoAnimal3);
        }

        private static void AddDatosEmpresa(){
            var empresa = new CentroVeterinario(999,"MyPet","Calle unica"); 
            _repoCentroVeterinario.AddCentroVeterinario(empresa);
        }
    }
}
