using System.Drawing;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeCohetes
{
    public class CoheteEspacial
    {
       
            // Propiedades
            string nombre;
            int altura;
            int peso;
            int cantidadMotores;
            int velocidad;
            
            string fabricante;


            public string GetNombre()
            {
                return nombre;
            }

            // Constructor
            public CoheteEspacial(string nombre, int altura, int peso, int cantidadMotores, string fabricante, int velocidad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.peso = peso;
                this.cantidadMotores = cantidadMotores;
                this.velocidad = velocidad;
                this.fabricante = fabricante;
            }
            // Método 
            public string MostrarDatos()
            {
                return $"Cohete: {nombre} | Altura: {altura} Metros | Velocidad: {velocidad} km/h | Cantidad de motores: {cantidadMotores} | Fabricante: {fabricante}";
            }

            public double CalcularTiempoDeViaje(double distancia)
            {
                double tiempoDeViaje = (distancia / velocidad)/24;
                return tiempoDeViaje;
            }
            

    }
}

