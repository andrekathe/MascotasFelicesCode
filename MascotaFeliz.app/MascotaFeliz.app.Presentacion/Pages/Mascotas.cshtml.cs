using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.app.Dominio.Entidades;
using MascotaFeliz.app.Persistencia.AppRepositorios;

namespace MascotaFeliz.app.Presentacion.Pages
{
    public class MascotasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioTipoAnimal repositorioTipoAnimal;
        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();
        public IEnumerable<TipoAnimal> listaTiposAnimales = new List<TipoAnimal>();
        public IEnumerable<Propietario> listaPropietarios = new List<Propietario>();

        [BindProperty]
        public Mascota mascota {get; set;} 
        [BindProperty]
        public int id {get; set;}          

        public MascotasModel(IRepositorioMascota repositorioMascota, IRepositorioTipoAnimal repositorioTipoAnimal, IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioMascota=repositorioMascota;
            this.repositorioTipoAnimal= repositorioTipoAnimal; //para el combo de tipo animal
            this.repositorioPropietario=repositorioPropietario; //para el combo de propietario
        }

        //Inicializador de la página
        public async Task OnGet()
        {
            listaMascotas = repositorioMascota.GetAllMascotas();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaPropietarios = repositorioPropietario.GetAllPropietarios();
        }

        public async Task OnPost()
        {
            listaMascotas = repositorioMascota.GetAllMascotas();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaPropietarios = repositorioPropietario.GetAllPropietarios();
        }

        public IActionResult OnPostInsert()
        {
            Mascota mascotaPost = new Mascota();
            TipoAnimal tipoAnimal = repositorioTipoAnimal.GetTipoAnimal(id);
            mascota.TipoAnimal=tipoAnimal;               
            mascotaPost = repositorioMascota.AddMascota(mascota);                           
                
            if(mascotaPost != null)
                return RedirectToPage("./Mascotas");
            else
                return RedirectToPage("./Error1");
            
        }

        public IActionResult OnPostUpdate()
        {            
            Mascota mascotaPost = new Mascota();  
            TipoAnimal tipoAnimal = repositorioTipoAnimal.GetTipoAnimal(id);
            mascota.TipoAnimal=tipoAnimal;                          
            mascotaPost = repositorioMascota.UpdateMascota(mascota);
            if(mascotaPost != null)
            {
                return RedirectToPage("./Mascotas");
            }        
            else
            {
                return RedirectToPage("./Error1");
            }
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioMascota.DeleteMascota(id);
                return RedirectToPage("./Mascotas");            
        }
    }
}
