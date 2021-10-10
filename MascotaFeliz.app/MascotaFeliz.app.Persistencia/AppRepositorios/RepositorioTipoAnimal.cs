using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioTipoAnimal : IRepositorioTipoAnimal
    {

        IEnumerable<TipoAnimal> IRepositorioTipoAnimal.GetAllTiposAnimales(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoTiposAnimales = (from p in Contexto.TiposAnimales select p).ToList();
                return listadoTiposAnimales;
            }
        }

        TipoAnimal IRepositorioTipoAnimal.AddTipoAnimal (TipoAnimal tipoAnimal){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var tipoAnimalAdicionado=Contexto.TiposAnimales.Add(tipoAnimal);
                Contexto.SaveChanges();
                return tipoAnimalAdicionado.Entity;
            }
        }

        TipoAnimal IRepositorioTipoAnimal.UpdateTipoAnimal (TipoAnimal tipoAnimal){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var tipoAnimalEncontrado = Contexto.TiposAnimales.FirstOrDefault(t=> t.Nombre==tipoAnimal.Nombre);
                if(tipoAnimalEncontrado!= null){
                    tipoAnimalEncontrado.Nombre = tipoAnimal.Nombre;
                    
                    Contexto.SaveChanges();
                }                      
                return tipoAnimalEncontrado;      
            }
        }

        void IRepositorioTipoAnimal.DeleteTipoAnimal (int idTipoAnimal){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var tipoAnimalEncontrado = Contexto.TiposAnimales.FirstOrDefault(t=> t.Id==idTipoAnimal);
                if(tipoAnimalEncontrado== null)
                    return;
                Contexto.TiposAnimales.Remove(tipoAnimalEncontrado);
                Contexto.SaveChanges();
            }
        }

        TipoAnimal IRepositorioTipoAnimal.GetTipoAnimal (int idTipoAnimal){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.TiposAnimales.FirstOrDefault(t=> t.Id==idTipoAnimal);
            }
        }
    }
}