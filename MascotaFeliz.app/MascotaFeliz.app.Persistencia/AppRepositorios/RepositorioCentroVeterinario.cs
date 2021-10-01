using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioCentroVeterinario : IRepositorioCentroVeterinario
    {
        private readonly EfAppContext _appContext;
        public RepositorioCentroVeterinario(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<CentroVeterinario> IRepositorioCentroVeterinario.GetAllCentrosVeterinarios(){
            return _appContext.CentrosVeterinarios;
        }
        CentroVeterinario IRepositorioCentroVeterinario.AddCentroVeterinario (CentroVeterinario centroVeterinario){
            var centroVeterinarioAdicionado=_appContext.CentrosVeterinarios.Add(centroVeterinario);
            _appContext.SaveChanges();
            return centroVeterinarioAdicionado.Entity;
        }
        CentroVeterinario IRepositorioCentroVeterinario.UpdateCentroVeterinario (CentroVeterinario centroVeterinario){
            var centroVeterinarioEncontrado = _appContext.CentrosVeterinarios.FirstOrDefault(p=> p.Nit==centroVeterinario.Nit);
            if(centroVeterinarioEncontrado!= null){
                centroVeterinarioEncontrado.Nit = centroVeterinario.Nit;
                centroVeterinarioEncontrado.Nombre = centroVeterinario.Nombre;
                centroVeterinarioEncontrado.Direccion = centroVeterinario.Direccion;
                
                _appContext.SaveChanges();
            }                      
            return centroVeterinarioEncontrado;      
        }
        void IRepositorioCentroVeterinario.DeleteCentroVeterinario (int nitCentroVeterinario){
            var centroVeterinarioEncontrado = _appContext.CentrosVeterinarios.FirstOrDefault(c=> c.Nit==nitCentroVeterinario);
            if(centroVeterinarioEncontrado== null)
                return;
            _appContext.CentrosVeterinarios.Remove(centroVeterinarioEncontrado);
            _appContext.SaveChanges();
        }
        CentroVeterinario IRepositorioCentroVeterinario.GetCentroVeterinario (int nitCentroVeterinario){
            return _appContext.CentrosVeterinarios.FirstOrDefault(c=> c.Nit==nitCentroVeterinario);
        }
    }
}