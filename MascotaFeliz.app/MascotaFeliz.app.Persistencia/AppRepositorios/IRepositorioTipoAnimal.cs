using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoAnimal
    {
        IEnumerable<TipoAnimal> GetAllTiposAnimales();
        TipoAnimal AddTipoAnimal (TipoAnimal tipoAnimal);
        TipoAnimal UpdateTipoAnimal (TipoAnimal tipoAnimal);
        void DeleteTipoAnimal (int nombreTipoAnimal);
        TipoAnimal GetTipoAnimal (int nombreTipoAnimal);
    }
}