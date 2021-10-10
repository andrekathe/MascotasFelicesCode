using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        
        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoPropietarios = (from p in Contexto.Propietarios select p).ToList();
                return listadoPropietarios;
            }
        }

        Propietario IRepositorioPropietario.AddPropietario (Propietario propietario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var propietarioAdicionada=Contexto.Propietarios.Add(propietario);
                Contexto.SaveChanges();
                return propietarioAdicionada.Entity;
            }
        }

        Propietario IRepositorioPropietario.UpdatePropietario (Propietario propietario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var propietarioEncontrado = Contexto.Propietarios.FirstOrDefault(p=> p.Id==propietario.Id);
                if(propietarioEncontrado!= null){
                    propietarioEncontrado.Direccion = propietario.Direccion;                
                    
                    Contexto.SaveChanges();
                }                      
                return propietarioEncontrado;      
            }
        }

        void IRepositorioPropietario.DeletePropietario (int idPropietario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var propietarioEncontrado = Contexto.Propietarios.FirstOrDefault(p=> p.Id==idPropietario);
                if(propietarioEncontrado== null)
                    return;
                Contexto.Propietarios.Remove(propietarioEncontrado);
                Contexto.SaveChanges();
            }
        }

        Propietario IRepositorioPropietario.GetPropietario (int idPropietario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.Propietarios.FirstOrDefault(p=> p.Id==idPropietario);
            }
        }
    }
}