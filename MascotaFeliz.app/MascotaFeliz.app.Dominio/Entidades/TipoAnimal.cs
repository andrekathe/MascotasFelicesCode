using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table("TipoAnimal")]
    public class TipoAnimal
    {
               
        [Column("Id")]
        [Key]         
        public int Id { get; set; }

        [Column("Animal")]
        [Required]
        [StringLength(50)]  
        public string Nombre { get; set; }
        
        public TipoAnimal()
        {
           
        }

        public TipoAnimal(string nombre) 
        {           
            this.Nombre = nombre;
               
        }
    }
}