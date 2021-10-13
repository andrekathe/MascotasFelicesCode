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
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();

        [BindProperty]
        public Mascota mascota {get; set;}

        public MascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota=repositorioMascota;
        }

        //Inicializador de la página
        public void OnGet()
        {
            listaMascotas = repositorioMascota.GetAllMascotas();
        }

        public IActionResult OnPost()
        {
            Mascota mascotaPost = new Mascota();      
            mascotaPost = repositorioMascota.AddMascota(mascota);                           
                
            if(mascotaPost != null)
                return RedirectToPage("./Mascotas");
            else
                return RedirectToPage("./Error1");
            
        }
    }
}
