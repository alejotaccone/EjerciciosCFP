using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Loro : Animal
    {

        public Loro(string nombre, double peso, int edad)
            :base(nombre, peso, edad)
        {
            
        }

        public override string EmitirSonido() 
        {       
            return "PRRRR PRRRR";
        }

    }
}
