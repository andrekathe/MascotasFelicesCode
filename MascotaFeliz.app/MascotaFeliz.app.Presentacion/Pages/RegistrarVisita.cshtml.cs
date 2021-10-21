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
    public class RegistrarVisitaModel : PageModel
    {
        private readonly IRepositorioVisitaProgramada repositorioVisitaProgramada; 
        private readonly IRepositorioRegistroVisita repositorioRegistroVisita;        
        public IEnumerable<VisitaProgramada> listadoSolicitudesVisita = new List<VisitaProgramada> ();  
        public IEnumerable<RegistroVisita> listadoRegistrosVisitas = new List<RegistroVisita> ();        

        [BindProperty]
        public RegistroVisita visita {get; set;}

        public RegistrarVisitaModel(IRepositorioVisitaProgramada repositorioVisitaProgramada, IRepositorioRegistroVisita repositorioRegistroVisita)
        {
            this.repositorioVisitaProgramada=repositorioVisitaProgramada;//para el combo de visitas programadas   
            this.repositorioRegistroVisita=repositorioRegistroVisita;
        }

        public async Task OnGet(int idSolicitudVisita)
        {
            listadoSolicitudesVisita = repositorioVisitaProgramada.GetAllVisitasProgramadas(); 
            listadoRegistrosVisitas = repositorioRegistroVisita.GetAllRegistrosVisitas();                                                           
        }

        public async Task OnPost()
        {
            listadoSolicitudesVisita = repositorioVisitaProgramada.GetAllVisitasProgramadas(); 
            listadoRegistrosVisitas = repositorioRegistroVisita.GetAllRegistrosVisitas();  
        }

        public IActionResult OnPostInsert()
        {
            RegistroVisita visitaPost = new RegistroVisita();      
            visitaPost = repositorioRegistroVisita.AddRegistroVisita(visita);                           
                
            if(visitaPost != null)
                return RedirectToPage("./RegistrarVisita");
            else
                return RedirectToPage("./Error1");
            
        }

        public IActionResult OnPostUpdate()
        {            
            RegistroVisita visitaPost = new RegistroVisita();      
            visitaPost = repositorioRegistroVisita.UpdateRegistroVisita(visita);                           
                
            if(visitaPost != null)
                return RedirectToPage("./RegistrarVisita");
            else
                return RedirectToPage("./Error1");
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioRegistroVisita.DeleteRegistroVisita(id);
                return RedirectToPage("./RegistrarVisita");            
        }
    }
}
