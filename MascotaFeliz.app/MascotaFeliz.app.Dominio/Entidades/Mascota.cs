using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    [Table("Mascota")]
    public class Mascota
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nombre")]
        [Required]
        [StringLength(50)]  
        public string Nombre { get; set; }

        [Column("ColorOjos")]
        public string ColorOjos { get; set; }

        [Column("ColorPiel")]
        public string ColorPiel { get; set; }

        [Column("Estatura")]
        public int Estatura{ get; set; }

        [Column("Peso")]
        public int Peso { get; set; }

        [Column("Raza")]
        public string Raza { get; set; }

        [Column("Sexo")]
        public string Sexo { get; set; }

        [ForeignKey("IdPropietario")]
        public virtual int IdPropietario { get; set; }

        [ForeignKey("IdTipoAnimal")]
        public virtual TipoAnimal TipoAnimal { get; set; }

        public Mascota(){}
    }    

}