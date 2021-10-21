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
    public class ProgramarVisitaModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioTipoAnimal repositorioTipoAnimal;
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioPropietario repositorioPropietario;
        private readonly IRepositorioVisitaProgramada repositorioVisitaProgramada;        
        public IEnumerable<VisitaProgramada> listadoSolicitudesVisita = new List<VisitaProgramada> (); 
        public IEnumerable<Medico> listadoMedicos = new List<Medico> ();
        public IEnumerable<TipoAnimal> listaTiposAnimales = new List<TipoAnimal>();
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();
        public IEnumerable<Propietario> listaPropietarios = new List<Propietario>();

        [BindProperty]
        public VisitaProgramada visita {get; set;}

        public ProgramarVisitaModel(IRepositorioVisitaProgramada repositorioVisitaProgramada, IRepositorioMedico repositorioMedico, IRepositorioTipoAnimal repositorioTipoAnimal, IRepositorioMascota repositorioMascota, IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioVisitaProgramada=repositorioVisitaProgramada;
            this.repositorioMedico=repositorioMedico;
            this.repositorioTipoAnimal= repositorioTipoAnimal; //para el combo de tipo animal
            this.repositorioMascota=repositorioMascota; //para el combo 
            this.repositorioPropietario=repositorioPropietario; //para el combo
        }

        public async Task OnGet()
        {
            listadoSolicitudesVisita = repositorioVisitaProgramada.GetAllVisitasProgramadas();
            listadoMedicos = repositorioMedico.GetAllMedicos();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaMascotas = repositorioMascota.GetAllMascotas();
            listaPropietarios = repositorioPropietario.GetAllPropietarios();
        }

        public async Task OnPost()
        {
            listadoSolicitudesVisita = repositorioVisitaProgramada.GetAllVisitasProgramadas();
            listadoMedicos = repositorioMedico.GetAllMedicos();
            listaTiposAnimales = repositorioTipoAnimal.GetAllTiposAnimales();
            listaMascotas = repositorioMascota.GetAllMascotas();
            listaPropietarios = repositorioPropietario.GetAllPropietarios();
        }

        public IActionResult OnPostInsert()
        {
            VisitaProgramada visitaPost = new VisitaProgramada();      
            visitaPost = repositorioVisitaProgramada.AddVisitaProgramada(visita);                           
                
            if(visitaPost != null)
                return RedirectToPage("./ProgramarVisita");
            else
                return RedirectToPage("./Error1");
            
        }

        public IActionResult OnPostUpdate()
        {            
            VisitaProgramada visitaPost = new VisitaProgramada();      
            visitaPost = repositorioVisitaProgramada.UpdateVisitaProgramada(visita);

            if(visitaPost != null)
                return RedirectToPage("./ProgramarVisita");
            else
                return RedirectToPage("./Error1");
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioVisitaProgramada.DeleteVisitaProgramada(id);
                return RedirectToPage("./ProgramarVisita");            
        }
    }
}
