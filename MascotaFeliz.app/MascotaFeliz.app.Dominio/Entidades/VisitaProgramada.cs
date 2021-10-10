using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table("VisitaProgramada")]
    public class VisitaProgramada
    {
        [Column("Id")]
        [Key] 
        public int Id { get; set; }

        [ForeignKey("IdMascota")]
        public virtual int IdMascota  { get; set; }

        [ForeignKey("IdPropietario")]
        public virtual int IdPropietario { get; set; }

        [ForeignKey("IdTipoAnimal")]
        public virtual TipoAnimal TipoAnimal { get; set; }

        [Column("Fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdMedico")]
        public virtual int IdMedico { get; set; }        

        public VisitaProgramada(){}
    }
    
}