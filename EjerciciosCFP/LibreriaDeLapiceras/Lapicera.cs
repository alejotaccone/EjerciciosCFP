using System.Drawing;
using System.Xml.Linq;

namespace LibreriaDeLapiceras
{
    public class Lapicera
    {

        //Crea la clase lapicera, esta debe tener los atributos: color, precio, marca, nivelDeTinta
        //Crear propiedades de todas las propiedad de lectura
        //Un constructor que inicialice color, precio, marca
        //Todas las lapiceras se crean con el nivel de tinta al 100
        //Sobreescribir el método ToString() para que muestre todos sus valores
        //Crear el método public bool Escribibr(int cantLetras), donde cada letra consume un nivel de tinta, el método debe verificar si tiene tinta
        //Para escribir la cantidad de letras, solicitarlas por parámetro e informar con un true o false si alcanzo
        //El método public void Recargar() que colocara el nivel de tinta a 100

        //2 Formularios, uno principar con el datagridview y el botón agregar y otro para crear lapiceras.

        private Color color;
        private int precio;
        private string marca;
        private int nivelDeTinta = 100;

        public Color Color { get => color;}
        public int Precio { get => precio;}
        public string Marca { get => marca;}
        public int NivelDeTinta { get => nivelDeTinta;}

        public Lapicera(Color color, int precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
            
        }

        public override string ToString()
        {
            return $"Precio: {Precio} - Color: {Color} - Marca: {Marca} - Nivel de tinta {NivelDeTinta}";
        }

        public bool Escribir(int cantLetras)
        {
            bool escribir = true;
            nivelDeTinta = nivelDeTinta - cantLetras;
            if (nivelDeTinta <= 0)
            {
                escribir = false;

            }

            return escribir;
        }

        
    }
}
