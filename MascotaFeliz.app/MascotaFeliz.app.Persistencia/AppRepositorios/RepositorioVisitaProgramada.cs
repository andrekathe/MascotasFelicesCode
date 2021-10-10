using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioVisitaProgramada : IRepositorioVisitaProgramada
    {
        
        IEnumerable<VisitaProgramada> IRepositorioVisitaProgramada.GetAllVisitasProgramadas(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoVisitasProgramadas = (from p in Contexto.VisitasProgramadas select p).ToList();
                return listadoVisitasProgramadas;
            }
        }

        VisitaProgramada IRepositorioVisitaProgramada.AddVisitaProgramada (VisitaProgramada visitaProgramada){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var visitaProgramadaAdicionada=Contexto.VisitasProgramadas.Add(visitaProgramada);
                Contexto.SaveChanges();
                return visitaProgramadaAdicionada.Entity;
            }
        }

        VisitaProgramada IRepositorioVisitaProgramada.UpdateVisitaProgramada (VisitaProgramada visitaProgramada){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var visitaProgramadaEncontrada = Contexto.VisitasProgramadas.FirstOrDefault(v=> v.Id==visitaProgramada.Id);
                if(visitaProgramadaEncontrada!= null){
                    visitaProgramadaEncontrada.IdMascota = visitaProgramada.IdMascota;
                    visitaProgramadaEncontrada.IdPropietario = visitaProgramada.IdPropietario;
                    visitaProgramadaEncontrada.TipoAnimal = visitaProgramada.TipoAnimal;
                    visitaProgramadaEncontrada.Fecha = visitaProgramada.Fecha;
                    visitaProgramadaEncontrada.IdMedico = visitaProgramada.IdMedico;
                    
                    Contexto.SaveChanges();
                }                      
                return visitaProgramadaEncontrada;      
            }
        }

        void IRepositorioVisitaProgramada.DeleteVisitaProgramada (int idVisitaProgramada){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var visitaProgramadaEncontrada = Contexto.VisitasProgramadas.FirstOrDefault(v=> v.Id==idVisitaProgramada);
                if(visitaProgramadaEncontrada== null)
                    return;
                Contexto.VisitasProgramadas.Remove(visitaProgramadaEncontrada);
                Contexto.SaveChanges();
            }
        }

        VisitaProgramada IRepositorioVisitaProgramada.GetVisitaProgramada (int idVisitaProgramada){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.VisitasProgramadas.FirstOrDefault(v=> v.Id==idVisitaProgramada);
            }
        }
    }
}