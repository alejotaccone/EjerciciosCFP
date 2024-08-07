namespace Libreria_de_clases
{
    public class Persona
    {
        string nombre;
        int edad;
        double peso;

        public Persona(string nombre, int edad, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
    }

   
}
