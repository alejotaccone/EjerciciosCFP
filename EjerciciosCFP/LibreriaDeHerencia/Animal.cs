using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public abstract class Animal
    {
        protected string nombre;
        protected double peso;
        protected int edad;

        public Animal(string nombre, double peso, int edad)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.edad = edad;
        }

        public abstract string EmitirSonido();
        

    }
}
