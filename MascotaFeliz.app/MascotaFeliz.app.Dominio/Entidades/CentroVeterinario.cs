using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table ("CentroVeterinario")]
    public class CentroVeterinario
    {
        [Key]
        [Column("Id")]  
        public int Id { get; set; }
        
        [Column("Nit")]
        [Required]        
        public int Nit { get; set; } 

        [Required]
        [Column("Nombre")]
        [StringLength(50)]               
        public string Nombre { get; set; }

        [Column("Direccion")]
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