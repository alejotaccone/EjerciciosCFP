using System.Drawing;

namespace LibreriaDeRobots
{
    public class Robot
    {
        //atributos
        string nombre;
        int fuerza;
        double peso;
        Color color;
        int vida;
        int energia;

        //setters
        public bool SetColor(Color nuevoColor)
        {
            bool logroCambiar = false;

            if (nuevoColor == Color.Black || nuevoColor == Color.Blue || nuevoColor == Color.Yellow)
            {
                this.color = nuevoColor;
                logroCambiar = true;
                
            }

            return logroCambiar;
        }

        //getters

        public Color GetColor()
        {
            return color;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public double GetPeso()
        {
            return peso;
        }

        public int GetFuerza()
        {
            return fuerza;
        }

        public int GetVida()
        {
            return vida;
        }

        //constructor

        public Robot(string nombre, int fuerza, double peso) { 
        
            this.fuerza = fuerza;
            this.peso = peso;
            this.nombre = nombre;
            this.color = Color.White;
            this.vida = 100;
            this.energia = 100;
        }

        //metodos
        public string RobotToString()
        {
            return $"Nombre: {nombre} | Vida: {vida} | Peso: {peso}kg | Fuerza: {fuerza} | Color: {color.Name}"; 
        }


        public int Atacar()
        {
            int golpe = 0;
            Random rnd = new Random();
            if (vida >0 && energia >0)
            {
                golpe = rnd.Next(1,50);
            }
            

            return golpe;
        }

        public void RecibirDanio(int cantidadDanio)
        {
            this.vida -= fuerza - cantidadDanio;
        }

    }
}
