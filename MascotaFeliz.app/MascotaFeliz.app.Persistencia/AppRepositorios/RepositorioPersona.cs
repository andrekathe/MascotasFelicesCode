using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly EfAppContext _appContext;
        public RepositorioPersona(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas(){
            return _appContext.Personas;
        }
        Persona IRepositorioPersona.AddPersona (Persona persona){
            var personaAdicionada=_appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }
        Persona IRepositorioPersona.UpdatePersona (Persona persona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p=> p.Id==persona.Id);
            if(personaEncontrada!= null){
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellido = persona.Apellido;
                personaEncontrada.Documento = persona.Documento;
                personaEncontrada.Telefono = persona.Telefono;
                
                _appContext.SaveChanges();
            }                      
            return personaEncontrada;      
        }
        void IRepositorioPersona.DeletePersona (int idPersona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p=> p.Id==idPersona);
            if(personaEncontrada== null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        Persona IRepositorioPersona.GetPersona (int idPersona){
            return _appContext.Personas.FirstOrDefault(p=> p.Id==idPersona);
        }
    }
}