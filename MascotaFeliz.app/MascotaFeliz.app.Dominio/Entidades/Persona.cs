using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table("Persona")]
    public class Persona
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Nombre")]
        [Required]
        [StringLength(50)]  
        public string Nombre { get; set; }

        [Column("Apellido")]
        [Required]
        [StringLength(50)]  
        public string Apellido { get; set; }

        [Column("DocumentoIdentidad")]
        [Required]
        [StringLength(10)]  
        public string Documento { get; set; }                

        [Column("Telefono")]
        public string Telefono { get; set; }            

        public Persona(){} //Constructor

        public Persona(string nombre, string apellido, string telefono){
            this.Nombre=nombre;
            this.Apellido=apellido;
            this.Telefono=telefono;
        }
    }

}