using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Gato : Animal
    {
        string color;
        string raza;

        public Gato(string nombre, double peso, int edad, string color, string raza)
            :base(nombre,peso,edad)
        {            
            this.color = color;
            this.raza = raza;
        }

        public override string EmitirSonido()
        {
            return "MIAU MIAU";
        }
    }
}
