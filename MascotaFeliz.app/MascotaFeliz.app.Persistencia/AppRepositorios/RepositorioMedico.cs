using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {

        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoMedicos = (from p in Contexto.Medicos select p).ToList();
                return listadoMedicos;
            }
        }

        Medico IRepositorioMedico.AddMedico (Medico medico){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var medicoAdicionado=Contexto.Medicos.Add(medico);
                Contexto.SaveChanges();
                return medicoAdicionado.Entity;
            }
        }

        Medico IRepositorioMedico.UpdateMedico (Medico medico){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var medicoEncontrado = Contexto.Medicos.FirstOrDefault(m=> m.Id==medico.Id);
                if(medicoEncontrado!= null){
                    medicoEncontrado.TarjetaProfesional = medico.TarjetaProfesional;
                    medicoEncontrado.Especializacion = medico.Especializacion;
                    medicoEncontrado.IdCentroVeterinario = medico.IdCentroVeterinario;
                    
                    Contexto.SaveChanges();
                }                      
                return medicoEncontrado;  
            }    
        }

        void IRepositorioMedico.DeleteMedico (int idMedico){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var medicoEncontrado = Contexto.Medicos.FirstOrDefault(m=> m.Id==idMedico);
                if(medicoEncontrado== null)
                    return;
                Contexto.Medicos.Remove(medicoEncontrado);
                Contexto.SaveChanges();
            }
        }

        Medico IRepositorioMedico.GetMedico (int idMedico){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.Medicos.FirstOrDefault(m=> m.Id==idMedico);
            }
        }
    }
}