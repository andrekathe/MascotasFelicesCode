using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotaFeliz.app.Dominio.Entidades
{
    
    public class Propietario:Persona
    {
        [Column("Direccion")]                
        public string Direccion { get; set; }

        public Propietario(){}    //Constructor
    }    
}