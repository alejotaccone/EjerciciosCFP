using LibreriaDeHerencia;
namespace TesteoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal loro1 = new Loro("Pepe",500,30);
            Animal gato1 = new Gato("Garfield", 5000, 4, "Naranja", "Angora");
            Animal perro1 = new Perro("Kaiser", 20000, 4, "Duro", "Pastor Aleman", "Alejo");
        
            List<Animal> animales = new List<Animal>();


            animales.Add(loro1);
            animales.Add(gato1);
            animales.Add(perro1);

            foreach (Animal animal in animales)
            {

                //if (animal is Perro)
                //{
                //    Console.WriteLine( ((Perro)animal).EmitirSonido() );                   
                //}else if (animal is Gato)
                //{
                //    Console.WriteLine(((Gato)animal).EmitirSonido());
                //}
                //else if (animal is Loro)
                //{
                //    Console.WriteLine(((Loro)animal).EmitirSonido());
                //}

                Console.WriteLine($"Tipo de animal: {animal.GetType().Name}  Sonido: {animal.EmitirSonido()}");


            }

        }
    }
}
