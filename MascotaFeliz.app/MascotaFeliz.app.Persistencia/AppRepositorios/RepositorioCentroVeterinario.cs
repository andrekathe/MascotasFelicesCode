using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppData;

namespace MascotaFeliz.app.Persistencia.AppRepositorios
{
    public class RepositorioCentroVeterinario : IRepositorioCentroVeterinario
    {           

        IEnumerable<CentroVeterinario> IRepositorioCentroVeterinario.GetAllCentrosVeterinarios(){
            //Conexión con Linq
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                //Consulta Linq
                var listadoCentrosVeterinarios = (from c in Contexto.CentrosVeterinarios select c).ToList();
                return listadoCentrosVeterinarios;
            }
            
        }

        CentroVeterinario IRepositorioCentroVeterinario.AddCentroVeterinario (CentroVeterinario centroVeterinario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var centroVeterinarioAdicionado= Contexto.CentrosVeterinarios.Add(centroVeterinario);
                Contexto.SaveChanges();
                return centroVeterinarioAdicionado.Entity;
            }
        }

        CentroVeterinario IRepositorioCentroVeterinario.UpdateCentroVeterinario (CentroVeterinario centroVeterinario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var centroVeterinarioEncontrado = Contexto.CentrosVeterinarios.FirstOrDefault(c=> c.Id==centroVeterinario.Id);
                if(centroVeterinarioEncontrado!= null){
                    centroVeterinarioEncontrado.Nit = centroVeterinario.Nit;
                    centroVeterinarioEncontrado.Nombre = centroVeterinario.Nombre;
                    centroVeterinarioEncontrado.Direccion = centroVeterinario.Direccion;
                    
                    Contexto.SaveChanges();
                }                      
                return centroVeterinarioEncontrado;    
            }  
        }

        void IRepositorioCentroVeterinario.DeleteCentroVeterinario (int idCentroVeterinario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){
                var centroVeterinarioEncontrado = Contexto.CentrosVeterinarios.FirstOrDefault(c=> c.Id==idCentroVeterinario);
                if(centroVeterinarioEncontrado== null)
                    return;
                Contexto.CentrosVeterinarios.Remove(centroVeterinarioEncontrado);
                Contexto.SaveChanges();
            }
        }

        CentroVeterinario IRepositorioCentroVeterinario.GetCentroVeterinario (int idCentroVeterinario){
            using(AppData.EfAppContext Contexto = new AppData.EfAppContext()){   
                //Sintaxis entityFramework            
                return Contexto.CentrosVeterinarios.FirstOrDefault(c=> c.Id==idCentroVeterinario);
            }
        }
    }
}