namespace MascotaFeliz.app.Dominio.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }            

        public Persona(){} //Constructor

        public Persona(string nombre, string apellido, string telefono){
            this.Nombre=nombre;
            this.Apellido=apellido;
            this.Telefono=telefono;
        }
    }

}