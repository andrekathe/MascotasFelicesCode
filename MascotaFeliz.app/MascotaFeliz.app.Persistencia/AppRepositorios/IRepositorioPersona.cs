using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona (Persona persona);
        Persona UpdatePersona (Persona persona);
        void DeletePersona (int idPersona);
        Persona GetPersona (int idPersona);
    }
}