namespace LibreriaDeVehiculos
{

    public abstract class Vehiculo
    {
        public string marca;
        public string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public abstract string Conducir();

        public virtual string MostrarInfo()
        {
            return $"Marca: {marca}, Modelo: {modelo}";
        }
    }
}
