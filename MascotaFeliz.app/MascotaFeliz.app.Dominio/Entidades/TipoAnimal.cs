namespace MascotaFeliz.app.Dominio.Entidades
{
    public class TipoAnimal
    {
               
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public TipoAnimal()
        {
           
        }

        public TipoAnimal(string nombre) 
        {           
            this.Nombre = nombre;
               
        }
    }
}