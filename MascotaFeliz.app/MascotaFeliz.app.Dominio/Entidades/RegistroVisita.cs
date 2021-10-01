namespace MascotaFeliz.app.Dominio.Entidades
{
    public class RegistroVisita
    {
        public int Id { get; set; }
        public int IdVisitaProgramada { get; set; }
        public int Temperatura { get; set; }
        public int Peso { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int FrecuenciaCardiaca { get; set; }        
        public string EstadoAnimo { get; set; }
        public string Recomendacion { get; set; }
        public string Medicamentos { get; set; }        

        public RegistroVisita(){}
    }
    
}