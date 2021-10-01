using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico (Medico medico);
        Medico UpdateMedico (Medico medico);
        void DeleteMedico (int tarjetaProfesional);
        Medico GetMedico (int tarjetaProfesional);
    }
}