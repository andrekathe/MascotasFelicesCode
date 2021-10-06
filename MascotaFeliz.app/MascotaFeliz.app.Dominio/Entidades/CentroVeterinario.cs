using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.app.Dominio.Entidades
{
    public class CentroVeterinario
    {
        [Key]
        public int Nit { get; set; }                
        public string Nombre { get; set; }    
        public string Direccion { get; set; }

        public CentroVeterinario()
        {
           
        }
    }    

}