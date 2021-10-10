using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioRegistroVisita : IRepositorioRegistroVisita
    {
        
        IEnumerable<RegistroVisita> IRepositorioRegistroVisita.GetAllRegistrosVisitas(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoRegistrosVisitas = (from p in Contexto.RegistrosVisitas select p).ToList();
                return listadoRegistrosVisitas;
            }
        }

        RegistroVisita IRepositorioRegistroVisita.AddRegistroVisita (RegistroVisita registroVisita){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var registroVisitaAdicionado=Contexto.RegistrosVisitas.Add(registroVisita);
                Contexto.SaveChanges();
                return registroVisitaAdicionado.Entity;
            }
        }

        RegistroVisita IRepositorioRegistroVisita.UpdateRegistroVisita (RegistroVisita registroVisita){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var registroVisitaEncontrado = Contexto.RegistrosVisitas.FirstOrDefault(p=> p.Id==registroVisita.Id);
                if(registroVisitaEncontrado!= null){
                    registroVisitaEncontrado.Temperatura = registroVisita.Temperatura;
                    registroVisitaEncontrado.Peso = registroVisita.Peso;
                    registroVisitaEncontrado.FrecuenciaRespiratoria = registroVisita.FrecuenciaRespiratoria;
                    registroVisitaEncontrado.FrecuenciaCardiaca = registroVisita.FrecuenciaCardiaca;
                    registroVisitaEncontrado.EstadoAnimo = registroVisita.EstadoAnimo;
                    registroVisitaEncontrado.Recomendacion = registroVisita.Recomendacion;
                    registroVisitaEncontrado.Medicamentos = registroVisita.Medicamentos;
                    
                    Contexto.SaveChanges();
                }                      
                return registroVisitaEncontrado; 
            }     
        }

        void IRepositorioRegistroVisita.DeleteRegistroVisita (int idRegistroVisita){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var registroVisitaEncontrado = Contexto.RegistrosVisitas.FirstOrDefault(r=> r.Id==idRegistroVisita);
                if(registroVisitaEncontrado== null)
                    return;
                Contexto.RegistrosVisitas.Remove(registroVisitaEncontrado);
                Contexto.SaveChanges();
            }
        }

        RegistroVisita IRepositorioRegistroVisita.GetRegistroVisita (int idRegistroVisita){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.RegistrosVisitas.FirstOrDefault(r=> r.Id==idRegistroVisita);
            }
        }
    }
}