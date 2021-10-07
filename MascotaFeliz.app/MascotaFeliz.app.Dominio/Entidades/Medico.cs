namespace MascotaFeliz.app.Dominio.Entidades
{
    public class Medico:Persona
    {         
        
        public int TarjetaProfesional { get; set; }
        public TipoAnimal Especializacion { get; set; }
        public int NitCentroVeterinario { get; set; }

        public Medico(){}

        public Medico(string nombre, string apellido, string telefono, int tarjetaProfesional, TipoAnimal especializacion, int nitCentroVeterinario) 
        :base(nombre, apellido, telefono)
        {            
            this.TarjetaProfesional = tarjetaProfesional;
            this.Especializacion = especializacion;
            this.NitCentroVeterinario = nitCentroVeterinario;
               
        }
    }
    
}