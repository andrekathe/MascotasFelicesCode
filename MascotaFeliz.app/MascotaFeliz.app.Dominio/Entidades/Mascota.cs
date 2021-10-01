namespace MascotaFeliz.app.Dominio.Entidades
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ColorOjos { get; set; }
        public string ColorPiel { get; set; }
        public int Estatura{ get; set; }
        public int Peso { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public int IdPropietario { get; set; }
        public TipoAnimal TipoAnimal { get; set; }

        public Mascota(){}
    }    

}