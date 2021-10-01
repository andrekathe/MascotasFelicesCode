using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario (Propietario propietario);
        Propietario UpdatePropietario (Propietario propietario);
        void DeletePropietario (int idPropietario);
        Propietario GetPropietario (int idPropietario);
    }
}