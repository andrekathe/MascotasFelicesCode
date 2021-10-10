using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table("RegistroVisita")]
    public class RegistroVisita
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdVisitaProgramada")]
        public virtual int IdVisitaProgramada { get; set; }

        [Column("Temperatura")]
        [Required]
        public int Temperatura { get; set; }

        [Column("Peso")]
        [Required]
        public int Peso { get; set; }

        [Column("FrecuenciaRespiratoria")]
        [Required]
        public int FrecuenciaRespiratoria { get; set; }
        
        [Column("FrecuenciaCardiaca")]
        [Required]
        public int FrecuenciaCardiaca { get; set; }        
        
        [Column("EstadoAnimo")]
        public string EstadoAnimo { get; set; }

        [Column("Recomendacion")]
        public string Recomendacion { get; set; }

        [Column("Medicamentos")]
        public string Medicamentos { get; set; }        

        public RegistroVisita(){}
    }
    
}