namespace MascotaFeliz.app.Dominio.Entidades
{
    public class Medico:Persona
    {
        public int TarjetaProfesional { get; set; }
        public TipoAnimal Especializacion { get; set; }
        public int NitCentroVeterinario { get; set; }

        public Medico(){}
    }
    
}