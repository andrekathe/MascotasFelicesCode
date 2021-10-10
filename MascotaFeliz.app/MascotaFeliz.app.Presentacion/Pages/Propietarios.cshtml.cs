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
        //[BindProperty] esto lo hicieron en los videos de moodle
        public IEnumerable<Propietario> listadoPropietarios = new List<Propietario>();

        public PropietariosModel(IRepositorioPropietario repositorioPropietario)
        {
            this.repositorioPropietario=repositorioPropietario;
        }

        public void OnGet()
        {
            listadoPropietarios = repositorioPropietario.GetAllPropietarios();
        }    
/*
        public void OnPost()
        {
            Propietarios=repositorioPropietario.UpdatePropietario(Propietario);
        }   
  */  }
}
