using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioRegistroVisita : IRepositorioRegistroVisita
    {
        private readonly EfAppContext _appContext;
        public RepositorioRegistroVisita(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<RegistroVisita> IRepositorioRegistroVisita.GetAllRegistrosVisitas(){
            return _appContext.RegistrosVisitas;
        }
        RegistroVisita IRepositorioRegistroVisita.AddRegistroVisita (RegistroVisita registroVisita){
            var registroVisitaAdicionado=_appContext.RegistrosVisitas.Add(registroVisita);
            _appContext.SaveChanges();
            return registroVisitaAdicionado.Entity;
        }
        RegistroVisita IRepositorioRegistroVisita.UpdateRegistroVisita (RegistroVisita registroVisita){
            var registroVisitaEncontrado = _appContext.RegistrosVisitas.FirstOrDefault(p=> p.Id==registroVisita.Id);
            if(registroVisitaEncontrado!= null){
                registroVisitaEncontrado.Temperatura = registroVisita.Temperatura;
                registroVisitaEncontrado.Peso = registroVisita.Peso;
                registroVisitaEncontrado.FrecuenciaRespiratoria = registroVisita.FrecuenciaRespiratoria;
                registroVisitaEncontrado.FrecuenciaCardiaca = registroVisita.FrecuenciaCardiaca;
                registroVisitaEncontrado.EstadoAnimo = registroVisita.EstadoAnimo;
                registroVisitaEncontrado.Recomendacion = registroVisita.Recomendacion;
                registroVisitaEncontrado.Medicamentos = registroVisita.Medicamentos;
                
                _appContext.SaveChanges();
            }                      
            return registroVisitaEncontrado;      
        }
        void IRepositorioRegistroVisita.DeleteRegistroVisita (int idRegistroVisita){
            var registroVisitaEncontrado = _appContext.RegistrosVisitas.FirstOrDefault(r=> r.Id==idRegistroVisita);
            if(registroVisitaEncontrado== null)
                return;
            _appContext.RegistrosVisitas.Remove(registroVisitaEncontrado);
            _appContext.SaveChanges();
        }
        RegistroVisita IRepositorioRegistroVisita.GetRegistroVisita (int idRegistroVisita){
            return _appContext.RegistrosVisitas.FirstOrDefault(r=> r.Id==idRegistroVisita);
        }
    }
}