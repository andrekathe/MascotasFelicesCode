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
        private readonly IRepositorioTipoAnimal repositorioTipoAnimal;
        private readonly IRepositorioCentroVeterinario repositorioCentroVeterinario;
        public IEnumerable<Medico> listadoMedicos = new List<Medico> ();
        public IEnumerable<TipoAnimal> listaTiposAnimales = new List<TipoAnimal>();
        public IEnumerable<CentroVeterinario> listaCentrosVeterinarios = new List<CentroVeterinario>();       

        [BindProperty]
        public Medico medico {get; set;}

        public MedicosModel(IRepositorioMedico repositorioMedico, IRepositorioTipoAnimal repositorioTipoAnimal, IRepositorioCentroVeterinario repositorioCentroVeterinario)
        {
            this.repositorioMedico=repositorioMedico;
            this.repositorioTipoAnimal= repositorioTipoAnimal; //para el combo de tipo animal
            this.repositorioCentroVeterinario=repositorioCentroVeterinario; //para el combo de centro veterinario
        }

        public async Task OnGet()
        {
            listadoMedicos = repositorioMedico.GetAllMedicos();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaCentrosVeterinarios = repositorioCentroVeterinario.GetAllCentrosVeterinarios();        
        }

        public async Task OnPost()
        {
            listadoMedicos = repositorioMedico.GetAllMedicos();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaCentrosVeterinarios = repositorioCentroVeterinario.GetAllCentrosVeterinarios();
        }

        public IActionResult OnPostInsert()
        {
            Medico medicoPost = new Medico();      
            medicoPost = repositorioMedico.AddMedico(medico);                           
                
            if(medicoPost != null)
                return RedirectToPage("./Medicos");
            else
                return RedirectToPage("./Error1");
            
        }

        public IActionResult OnPostUpdate()
        {            
            Medico medicoPost = new Medico();                        
            medicoPost = repositorioMedico.UpdateMedico(medico);
            if(medicoPost != null)
            {
                return RedirectToPage("./Medicos");
            }        
            else
            {
                return RedirectToPage("./Error1");
            }
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioMedico.DeleteMedico(id);
                return RedirectToPage("./Medicos");            
        }
    }
}
