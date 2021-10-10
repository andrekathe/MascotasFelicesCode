using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas(){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var listadoMascotas = (from p in Contexto.Mascotas select p).ToList();
                return listadoMascotas;
            }
        }

        Mascota IRepositorioMascota.AddMascota (Mascota mascota){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var mascotaAdicionada=Contexto.Mascotas.Add(mascota);
                Contexto.SaveChanges();
                return mascotaAdicionada.Entity;
            }
        }

        Mascota IRepositorioMascota.UpdateMascota (Mascota mascota){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var mascotaEncontrada = Contexto.Mascotas.FirstOrDefault(m=> m.Id==mascota.Id);
                if(mascotaEncontrada!= null){
                    mascotaEncontrada.Nombre = mascota.Nombre;
                    mascotaEncontrada.ColorOjos = mascota.ColorOjos;
                    mascotaEncontrada.ColorPiel = mascota.ColorPiel;
                    mascotaEncontrada.Estatura = mascota.Estatura;
                    mascotaEncontrada.Peso = mascota.Peso;
                    mascotaEncontrada.Raza = mascota.Raza;
                    mascotaEncontrada.Sexo = mascota.Sexo;
                    mascotaEncontrada.IdPropietario = mascota.IdPropietario;
                    mascotaEncontrada.TipoAnimal = mascota.TipoAnimal;
                    
                    Contexto.SaveChanges();
                }                      
                return mascotaEncontrada;    
            }  
        }

        void IRepositorioMascota.DeleteMascota (int idMascota){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var mascotaEncontrada = Contexto.Mascotas.FirstOrDefault(m=> m.Id==idMascota);
                if(mascotaEncontrada== null)
                    return;
                Contexto.Mascotas.Remove(mascotaEncontrada);
                Contexto.SaveChanges();
            }
        }

        Mascota IRepositorioMascota.GetMascota (int idMascota){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                return Contexto.Mascotas.FirstOrDefault(m=> m.Id==idMascota);
            }
        }
    }
}