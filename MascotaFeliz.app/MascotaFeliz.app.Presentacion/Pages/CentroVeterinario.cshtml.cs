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

        public CentroVeterinarioModel(IRepositorioCentroVeterinario repositorioCentroVeterinario){
            this.repositorioCentroVeterinario=repositorioCentroVeterinario;
        }

        public void OnGet()
        {
            listaCentrosVeterinarios= repositorioCentroVeterinario.GetAllCentrosVeterinarios();
        }
    }
}
