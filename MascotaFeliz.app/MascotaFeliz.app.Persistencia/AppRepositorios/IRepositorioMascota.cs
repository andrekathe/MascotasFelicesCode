using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota (Mascota mascota);
        Mascota UpdateMascota (Mascota mascota);
        void DeleteMascota (int idMascota);
        Mascota GetMascota (int idMascota);
    }
}