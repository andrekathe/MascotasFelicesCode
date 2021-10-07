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
        public IEnumerable<Mascota> Mascotas {get;set;}

        public MascotasModel(IRepositorioMascota repositorioMascota)
        {
            this.repositorioMascota=repositorioMascota;
        }

        public void OnGet()
        {
            Mascotas = repositorioMascota.GetAllMascotas();
        }
    }
}
