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
    public class CentroVeterinarioModel : PageModel
    {
        private readonly IRepositorioCentroVeterinario repositorioCentroVeterinario;
        public IEnumerable<CentroVeterinario> listaCentrosVeterinarios = new List<CentroVeterinario>();
        
        [BindProperty]
        public CentroVeterinario empresa {get; set;}

        public CentroVeterinarioModel(IRepositorioCentroVeterinario repositorioCentroVeterinario){
            this.repositorioCentroVeterinario=repositorioCentroVeterinario;
        }

        public void OnGet()
        {
            listaCentrosVeterinarios= repositorioCentroVeterinario.GetAllCentrosVeterinarios();
        }

        public IActionResult OnPost()
        {
            CentroVeterinario empresaPost = new CentroVeterinario();      
            empresaPost = repositorioCentroVeterinario.AddCentroVeterinario(empresa);                           
                
            if(empresaPost != null)
                return RedirectToPage("./CentroVeterinario");
            else
                return RedirectToPage("./Error1");
            
        }

        public IActionResult OnPostUpdate()
        {            
            CentroVeterinario empresaPost = new CentroVeterinario();                        
            empresaPost = repositorioCentroVeterinario.UpdateCentroVeterinario(empresa);
            if(empresaPost != null)
            {
                return RedirectToPage("./CentroVeterinario");
            }        
            else
            {
                return RedirectToPage("./Error1");
            }
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioCentroVeterinario.DeleteCentroVeterinario(id);
                return RedirectToPage("./CentroVeterinario");            
        }
    }
}
