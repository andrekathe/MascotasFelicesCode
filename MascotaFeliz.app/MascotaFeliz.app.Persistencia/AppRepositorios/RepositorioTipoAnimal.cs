using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioTipoAnimal : IRepositorioTipoAnimal
    {
        private readonly EfAppContext _appContext;
        public RepositorioTipoAnimal(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<TipoAnimal> IRepositorioTipoAnimal.GetAllTiposAnimales(){
            return _appContext.TiposAnimales;
        }
        TipoAnimal IRepositorioTipoAnimal.AddTipoAnimal (TipoAnimal tipoAnimal){
            var tipoAnimalAdicionado=_appContext.TiposAnimales.Add(tipoAnimal);
            _appContext.SaveChanges();
            return tipoAnimalAdicionado.Entity;
        }
        TipoAnimal IRepositorioTipoAnimal.UpdateTipoAnimal (TipoAnimal tipoAnimal){
            var tipoAnimalEncontrado = _appContext.TiposAnimales.FirstOrDefault(t=> t.Nombre==tipoAnimal.Nombre);
            if(tipoAnimalEncontrado!= null){
                tipoAnimalEncontrado.Nombre = tipoAnimal.Nombre;
                
                _appContext.SaveChanges();
            }                      
            return tipoAnimalEncontrado;      
        }
        void IRepositorioTipoAnimal.DeleteTipoAnimal (int idTipoAnimal){
            var tipoAnimalEncontrado = _appContext.TiposAnimales.FirstOrDefault(t=> t.Id==idTipoAnimal);
            if(tipoAnimalEncontrado== null)
                return;
            _appContext.TiposAnimales.Remove(tipoAnimalEncontrado);
            _appContext.SaveChanges();
        }
        TipoAnimal IRepositorioTipoAnimal.GetTipoAnimal (int idTipoAnimal){
            return _appContext.TiposAnimales.FirstOrDefault(t=> t.Id==idTipoAnimal);
        }
    }
}