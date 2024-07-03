using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeVehiculos
{
    public class Coche : Vehiculo
    {
        public int numeroPuertas;
        public double capacidadMaletero;

        public Coche(string marca, string modelo, int numeroPuertas, double capacidadMaletero)
            : base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadMaletero = capacidadMaletero;
        }

        public override string Conducir()
        {
            return "Conduciendo un coche";
        }

        public string AbrirMaletero()
        {
            return "El maletero del coche se ha abierto";
        }

        public override string MostrarInfo()
        {
            
            return $"{base.MostrarInfo()}, Número de puertas: {numeroPuertas}, Capacidad del maletero: {capacidadMaletero} litros";
        }
    }
}
