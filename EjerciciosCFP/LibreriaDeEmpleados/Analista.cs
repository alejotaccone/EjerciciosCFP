using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Analista : Empleado
    {

        //Definir la clase derivada Analista:
        //Crear la clase Analista que herede de Empleado.
        //Agregar los atributos Especialidad y Proyectos.
        //Implementar el método Trabajar() para que imprima "El analista está analizando los datos."
        //Sobrescribir CalcularBonificacion() para calcular una bonificación específica para analistas, los desarrolladores reciben una bonificacion del 10% del salario.
        //Implementar el método PrepararInforme(), debe informar que le analista esta preparando los informes de sus proyectos.
        //Implementar el método SalarioTotal().

        protected string especialidad;
        protected string proyectos;

        public Analista(string nombre, double salario, string departamento, int antiguedad, string especialidad, string proyectos)
            : base(nombre, salario, departamento, antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }

        public override string Trabajar()
        {
            return "El analista está analizando los datos.";
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo} - Especialidad: {especialidad} - Proyectos: {proyectos}";
        }

        public override double CalcularBonificacion()
        {
            return salario*0.1;
        }

        public override double SueldoTotal()
        {
            return salario + CalcularBonificacion();
        }

        public string PrepararInforme()
        {
            return $"El analista esta preparando los informes del/los proyecto/s {proyectos}.";
        }
    }
}
