using System;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;
using MascotaFeliz.app.Persistencia.AppRepositorios;

namespace MascotaFeliz.app.Console
{
    class Program
    {
        //private static IRepositorioMedico _repoMedico= new RepositorioMedico(new EfAppContext());
        private static IRepositorioTipoAnimal _repoTipoAnimal= new RepositorioTipoAnimal(new EfAppContext());
        //private static IRepositorioCentroVeterinario _repoCentroVeterinario= new RepositorioCentroVeterinario(new EfAppContext());

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
            var tipoAnimal = new TipoAnimal("Ave");  
            _repoTipoAnimal.AddTipoAnimal(tipoAnimal);
/*
            var centroVeterinario = new CentroVeterinario(999, "mi mascota","Calle unica");
            _repoCentroVeterinario.AddCentroVeterinario(centroVeterinario);

            /*var medico=new Medico("Andrea", "Munoz", "3128902012", 1234, tipoAnimal,999);
            _repoMedico.AddMedico(medico);
        }

        private static void GetMedico(int idMedico){
            var medico= _repoMedico.GetMedico(idMedico);
            System.Console.WriteLine(medico.Nombre+" "+medico.Apellido);*/
        }
    }
}
