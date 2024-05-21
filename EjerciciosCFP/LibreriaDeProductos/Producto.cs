namespace LibreriaDeProductos
{
    public class Producto
    {
        string marca;
        double precio;
        string tipo;
        int peso;




        //Constructor
        public Producto(string marca, double precio, string tipo, int peso)
        {
            this.marca = marca;
            this.precio = precio;
            this.tipo = tipo;
            this.peso = peso;
        }

       
        //Metodos
        public string ToString()
        {
            return $"Producto: {marca}, Precio: {precio}, Tipo de producto: {tipo}, Peso de la unidad {peso}";
        }




    }
}
