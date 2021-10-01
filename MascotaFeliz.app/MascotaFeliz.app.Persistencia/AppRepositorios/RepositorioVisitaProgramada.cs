using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioVisitaProgramada : IRepositorioVisitaProgramada
    {
        private readonly EfAppContext _appContext;
        public RepositorioVisitaProgramada(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<VisitaProgramada> IRepositorioVisitaProgramada.GetAllVisitasProgramadas(){
            return _appContext.VisitasProgramadas;
        }
        VisitaProgramada IRepositorioVisitaProgramada.AddVisitaProgramada (VisitaProgramada visitaProgramada){
            var visitaProgramadaAdicionada=_appContext.VisitasProgramadas.Add(visitaProgramada);
            _appContext.SaveChanges();
            return visitaProgramadaAdicionada.Entity;
        }
        VisitaProgramada IRepositorioVisitaProgramada.UpdateVisitaProgramada (VisitaProgramada visitaProgramada){
            var visitaProgramadaEncontrada = _appContext.VisitasProgramadas.FirstOrDefault(v=> v.Id==visitaProgramada.Id);
            if(visitaProgramadaEncontrada!= null){
                visitaProgramadaEncontrada.IdMascota = visitaProgramada.IdMascota;
                visitaProgramadaEncontrada.IdPropietario = visitaProgramada.IdPropietario;
                visitaProgramadaEncontrada.TipoAnimal = visitaProgramada.TipoAnimal;
                visitaProgramadaEncontrada.Fecha = visitaProgramada.Fecha;
                visitaProgramadaEncontrada.IdMedico = visitaProgramada.IdMedico;
                
                _appContext.SaveChanges();
            }                      
            return visitaProgramadaEncontrada;      
        }
        void IRepositorioVisitaProgramada.DeleteVisitaProgramada (int idVisitaProgramada){
            var visitaProgramadaEncontrada = _appContext.VisitasProgramadas.FirstOrDefault(v=> v.Id==idVisitaProgramada);
            if(visitaProgramadaEncontrada== null)
                return;
            _appContext.VisitasProgramadas.Remove(visitaProgramadaEncontrada);
            _appContext.SaveChanges();
        }
        VisitaProgramada IRepositorioVisitaProgramada.GetVisitaProgramada (int idVisitaProgramada){
            return _appContext.VisitasProgramadas.FirstOrDefault(v=> v.Id==idVisitaProgramada);
        }
    }
}