namespace LibreriaDePersonas
{
    public class Persona
    {

        //Atributos

        int legajo;
        string nombre;
        string apellido;
        double sueldo;
        string areaDeTrabajo;


        //metodos Set y Get

        public double GetSueldo()
        {
            return sueldo;
        }

        public void SetSueldo(double sueldo)
        {
            this.sueldo = sueldo;
            
        }


        //propiedades -- son una mezcla entre los atreibutos y metodos


        //Constructor
        //visibilidad
        //Comportamiento -- estatico o de instancia
        //NUNCA TIENEN RETORNO
        //nombre SIEMPRE EL MISMO QUE LA CLASE
        //parametros

        public Persona(int legajo, string nombre,string apellido,double sueldo,string area)
        {
            this.legajo = legajo;
            this.nombre = nombre;   
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.areaDeTrabajo = area;
             
        }

        //public Persona(int legajo, string nombre, string apellido)
        //{
        //    this.legajo = legajo;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.sueldo = 0;
        //    this.areaDeTrabajo = "Sin puesto";

        //}


        //Metodos
        //visibilidad
        //Comportamiento -- estatico o de instancia
        //retorno
        //nombre
        //parametros

        public string InformarDatos()
        { 
            return $"Legajo: {legajo} - Nombre:{nombre} {apellido} - Area de trabajp: {areaDeTrabajo} - Sueldo: ${sueldo}";
        }

    }
}
