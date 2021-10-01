using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly EfAppContext _appContext;
        public RepositorioPropietario(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios(){
            return _appContext.Propietarios;
        }
        Propietario IRepositorioPropietario.AddPropietario (Propietario propietario){
            var propietarioAdicionada=_appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionada.Entity;
        }
        Propietario IRepositorioPropietario.UpdatePropietario (Propietario propietario){
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p=> p.Id==propietario.Id);
            if(propietarioEncontrado!= null){
                propietarioEncontrado.Direccion = propietario.Direccion;                
                
                _appContext.SaveChanges();
            }                      
            return propietarioEncontrado;      
        }
        void IRepositorioPropietario.DeletePropietario (int idPropietario){
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p=> p.Id==idPropietario);
            if(propietarioEncontrado== null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }
        Propietario IRepositorioPropietario.GetPropietario (int idPropietario){
            return _appContext.Propietarios.FirstOrDefault(p=> p.Id==idPropietario);
        }
    }
}