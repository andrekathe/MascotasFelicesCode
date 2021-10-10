using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoPersonas = (from p in Contexto.Personas select p).ToList();
                return listadoPersonas;
            }
        }

        Persona IRepositorioPersona.AddPersona (Persona persona){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var personaAdicionada=Contexto.Personas.Add(persona);
                Contexto.SaveChanges();
                return personaAdicionada.Entity;
            }
        }

        Persona IRepositorioPersona.UpdatePersona (Persona persona){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var personaEncontrada = Contexto.Personas.FirstOrDefault(p=> p.Id==persona.Id);
                if(personaEncontrada!= null){
                    personaEncontrada.Nombre = persona.Nombre;
                    personaEncontrada.Apellido = persona.Apellido;
                    personaEncontrada.Documento = persona.Documento;
                    personaEncontrada.Telefono = persona.Telefono;
                    
                    Contexto.SaveChanges();
                }                      
                return personaEncontrada;   
            }   
        }

        void IRepositorioPersona.DeletePersona (int idPersona){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var personaEncontrada = Contexto.Personas.FirstOrDefault(p=> p.Id==idPersona);
                if(personaEncontrada== null)
                    return;
                Contexto.Personas.Remove(personaEncontrada);
                Contexto.SaveChanges();
            }
        }

        Persona IRepositorioPersona.GetPersona (int idPersona){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.Personas.FirstOrDefault(p=> p.Id==idPersona);
            }
        }
    }
}