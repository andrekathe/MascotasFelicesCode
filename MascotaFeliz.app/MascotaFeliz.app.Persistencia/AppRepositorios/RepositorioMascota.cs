using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly EfAppContext _appContext;
        public RepositorioMascota(EfAppContext appContext){
            _appContext=appContext;
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas(){
            return _appContext.Mascotas;
        }
        Mascota IRepositorioMascota.AddMascota (Mascota mascota){
            var mascotaAdicionada=_appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }
        Mascota IRepositorioMascota.UpdateMascota (Mascota mascota){
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m=> m.Id==mascota.Id);
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
                
                _appContext.SaveChanges();
            }                      
            return mascotaEncontrada;      
        }
        void IRepositorioMascota.DeleteMascota (int idMascota){
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m=> m.Id==idMascota);
            if(mascotaEncontrada== null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
        }
        Mascota IRepositorioMascota.GetMascota (int idMascota){
            return _appContext.Mascotas.FirstOrDefault(m=> m.Id==idMascota);
        }
    }
}