using Microsoft.VisualBasic;
using System.Drawing;

namespace LibreriaDeEmpleados
{
    public abstract class Empleado
    {
        //Definir la clase abstracta Empleado:
        //Crear la clase Empleado con los atributos Nombre, Salario, Departamento, Antiguedad.
        //Declarar el método abstracto Trabajar().
        //Implementar el método virtual MostrarInfo() para mostrar la información básica del empleado.
        //Implementar el método virtual CalcularBonificacion() para calcular una bonificación base, por defecto es 0.
        //Declarar el método abstracto SueldoTotal(),
        //retorna la informacion de la suma del sueldo mas el valor de la bonificacion

        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        protected Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        }

        public virtual double CalcularBonificacion()
        {
            return 0;
        }

        public abstract double SueldoTotal();


    }
}
