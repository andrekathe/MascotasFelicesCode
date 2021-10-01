using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistroVisita
    {
        IEnumerable<RegistroVisita> GetAllRegistrosVisitas();
        RegistroVisita AddRegistroVisita (RegistroVisita registroVisita);
        RegistroVisita UpdateRegistroVisita (RegistroVisita registroVisita);
        void DeleteRegistroVisita (int idRegistroVisita);
        RegistroVisita GetRegistroVisita (int idRegistroVisita);
    }
}