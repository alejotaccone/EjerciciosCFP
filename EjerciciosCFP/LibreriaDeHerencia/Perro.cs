namespace LibreriaDeHerencia
{
    public class Perro : Animal
    {    
        string tipoDePelo;
        string raza;
        string duenio;

        public Perro(string nombre, double peso, int edad, string tipoDePelo, string raza, string duenio = null)
            : base(nombre, peso, edad)
        {  
            this.tipoDePelo = tipoDePelo;
            this.raza = raza;
            this.duenio = duenio;
        }

        public override string EmitirSonido()
        {
            return "GUAU GUAU";
        }
    }
}
