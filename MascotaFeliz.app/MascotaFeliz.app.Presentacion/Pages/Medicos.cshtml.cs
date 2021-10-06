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
        public IEnumerable<Medico> Medicos {get;set;}

        public MedicosModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico=repositorioMedico;
        }

        public void OnGet()
        {
            Medicos = repositorioMedico.GetAllMedicos();
        }
    }
}
