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
    public class PropietariosModel : PageModel
    {
        
        private readonly IRepositorioPropietario repositorioPropietario;        
        public IEnumerable<Propietario> listadoPropietarios = new List<Propietario>();

        [BindProperty]
        public Propietario propietario {get; set;}

        public PropietariosModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=repositorioPropietario;
        }

        public void OnGet()
        {
            listadoPropietarios = repositorioPropietario.GetAllPropietarios();
        }   

        public void OnPost()
        {
            listadoPropietarios = repositorioPropietario.GetAllPropietarios();
        }   

        public IActionResult OnPostInsert()
        {
            Propietario propietarioPost = new Propietario();      
            propietarioPost = repositorioPropietario.AddPropietario(propietario);                           
                
            if(propietarioPost != null)
                return RedirectToPage("./Propietarios");
            else
                return RedirectToPage("./Error1");
            
        } 

        public IActionResult OnPostUpdate()
        {            
            Propietario propietarioPost = new Propietario();                        
            propietarioPost = repositorioPropietario.UpdatePropietario(propietario);
            if(propietarioPost != null)
            {
                return RedirectToPage("./Propietarios");
            }        
            else
            {
                return RedirectToPage("./Error1");
            }
        }

        public IActionResult OnPostDelete(int id)
        {            
                repositorioPropietario.DeletePropietario(id);
                return RedirectToPage("./Propietarios");            
        }
    }
}
