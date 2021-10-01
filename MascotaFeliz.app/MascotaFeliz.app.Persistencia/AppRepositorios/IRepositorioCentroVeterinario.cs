using System.Collections.Generic;
using MascotaFeliz.app.Dominio.Entidades;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public interface IRepositorioCentroVeterinario
    {
        IEnumerable<CentroVeterinario> GetAllCentrosVeterinarios();
        CentroVeterinario AddCentroVeterinario (CentroVeterinario centroVeterinario);
        CentroVeterinario UpdateCentroVeterinario (CentroVeterinario centroVeterinario);
        void DeleteCentroVeterinario (int nitCentroVeterinario);
        CentroVeterinario GetCentroVeterinario (int nitCentroVeterinario);
    }
}