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
    public class MedicosModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public IEnumerable<Medico> listadoMedicos = new List<Medico> ();

        [BindProperty]
        public Medico medico {get; set;}

        public MedicosModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico=repositorioMedico;
        }

        public void OnGet()
        {
            listadoMedicos = repositorioMedico.GetAllMedicos();
        }

        public IActionResult OnPost()
        {
            Medico medicoPost = new Medico();      
            medicoPost = repositorioMedico.AddMedico(medico);                           
                
            if(medicoPost != null)
                return RedirectToPage("./Medico");
            else
                return RedirectToPage("./Error1");
            
        }
    }
}
