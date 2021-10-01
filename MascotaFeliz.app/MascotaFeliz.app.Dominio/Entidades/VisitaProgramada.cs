namespace MascotaFeliz.app.Dominio.Entidades
{
    public class VisitaProgramada
    {
        public int Id { get; set; }
        public int IdMascota  { get; set; }
        public int IdPropietario { get; set; }
        public TipoAnimal TipoAnimal { get; set; }
        public string Fecha { get; set; }
        public int IdMedico { get; set; }        

        public VisitaProgramada(){}
    }
    
}