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

        public CentroVeterinario(int nit, string nombre, string direccion) 
        {
            this.Nit = nit;
            this.Nombre = nombre;
            this.Direccion = direccion;
               
        }
        
    }    

}