using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly EfAppContext _appContext;
        public RepositorioMedico(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos(){
            return _appContext.Medicos;
        }
        Medico IRepositorioMedico.AddMedico (Medico medico){
            var medicoAdicionado=_appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }
        Medico IRepositorioMedico.UpdateMedico (Medico medico){
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m=> m.Id==medico.Id);
            if(medicoEncontrado!= null){
                medicoEncontrado.TarjetaProfesional = medico.TarjetaProfesional;
                medicoEncontrado.Especializacion = medico.Especializacion;
                medicoEncontrado.IdCentroVeterinario = medico.IdCentroVeterinario;
                
                _appContext.SaveChanges();
            }                      
            return medicoEncontrado;      
        }
        void IRepositorioMedico.DeleteMedico (int tarjetaProfesional){
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m=> m.TarjetaProfesional==tarjetaProfesional);
            if(medicoEncontrado== null)
                return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
        Medico IRepositorioMedico.GetMedico (int tarjetaProfesional){
            return _appContext.Medicos.FirstOrDefault(m=> m.TarjetaProfesional==tarjetaProfesional);
        }
    }
}