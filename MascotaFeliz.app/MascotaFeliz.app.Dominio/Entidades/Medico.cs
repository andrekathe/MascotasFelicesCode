using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{    
    [Table("Medico")]
    public class Medico:Persona
    {                
        [Required]
        [Column("TarjetaProfesional")]
        public int TarjetaProfesional { get; set; }

        [ForeignKey("IdTipoAnimal")]
        public virtual TipoAnimal Especializacion { get; set; }

        [ForeignKey("IdCentroVeterinario")]
        public virtual int IdCentroVeterinario { get; set; }

        public Medico(){}

        public Medico(string nombre, string apellido, string telefono, int tarjetaProfesional, TipoAnimal especializacion, int idCentroVeterinario) 
        :base(nombre, apellido, telefono)
        {            
            this.TarjetaProfesional = tarjetaProfesional;
            this.Especializacion = especializacion;
            this.IdCentroVeterinario = idCentroVeterinario;
               
        }
    }
    
}