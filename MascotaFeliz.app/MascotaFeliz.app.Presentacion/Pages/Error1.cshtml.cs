using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFeliz.app.Presentacion.Pages
{
    public class Error1Model : PageModel
    {
        private readonly ILogger<Error1Model> _logger;

        public Error1Model(ILogger<Error1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
