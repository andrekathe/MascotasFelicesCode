using System;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;
using MascotaFeliz.app.Persistencia.AppRepositorios;

namespace MascotaFeliz.app.Console
{
    class Program
    {
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new EfAppContext());
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
          //  AddPersona();
        }

        private static void AddPersona(){
            var persona = new Persona("Andrea", "Munoz", "3128902012");
            _repoPersona.AddPersona(persona);
        }

        private static void GetPersona(int idPersona){
            var persona= _repoPersona.GetPersona(idPersona);
            System.Console.WriteLine(persona.Nombre+" "+persona.Apellido);
        }
    }
}
