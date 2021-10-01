using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioVisitaProgramada
    {
        IEnumerable<VisitaProgramada> GetAllVisitasProgramadas();
        VisitaProgramada AddVisitaProgramada (VisitaProgramada visitaProgramada);
        VisitaProgramada UpdateVisitaProgramada (VisitaProgramada visitaProgramada);
        void DeleteVisitaProgramada (int idVisitaProgramada);
        VisitaProgramada GetVisitaProgramada (int idVisitaProgramada);
    }
}