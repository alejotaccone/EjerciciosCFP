using System.Drawing;

namespace LibreriaDeRobots
{
    public class Robot
    {
        //atributos
        string nombre;
        double resistencia;
        double peso;
        Color color;
        int vida;
        public int energia;
        static Random rnd;
        

        


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

        public double GetResistencia()
        {
            return resistencia;
        }

        public int GetVida()
        {
            return vida;
        }

        //constructor

        public Robot(string nombre, int resistencia, double peso) { 
        
            this.resistencia = resistencia;
            this.peso = peso;
            this.nombre = nombre;
            this.color = Color.White;
            this.vida = 100;
            this.energia = 100;
        }

        static Robot()
        {
            Robot.rnd = new Random();
        }

        //metodos
        public string RobotToString()
        {
            return $"Nombre: {nombre} | Vida: {vida} | Peso: {peso}kg | Fuerza: {resistencia} | Color: {color.Name}"; 
        }


        public int Atacar()
        {
            int golpe = 0;
            

            //por cada ataque pierde energia
            this.energia -= 5;

            //en base a la energia se potencia el golpe

            if (vida >0 && energia >0)
            {
                golpe = Robot.rnd.Next(1,this.energia);
            } 

            return golpe * rnd.Next(1,3);
        }

        public void RecibirDanio(int cantidadDanio)
        {
            //por cada golpe recibido bajar resistencia(HAGA O NO DANIO)

            
            int danioTotal = (int)resistencia - cantidadDanio;
            if (danioTotal < 0)
            {
                this.vida += danioTotal; //Ej -> viva(100) + danio(-15)
            }
            if (this.vida < 0)
            {
                this.vida = 0;
            }
            this.BajarResistencia();
        }

        private void BajarResistencia()
        {
            this.resistencia = this.resistencia * 0.95;
        }

    }
}
