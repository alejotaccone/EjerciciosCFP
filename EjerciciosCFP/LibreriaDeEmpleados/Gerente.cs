using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Gerente : Empleado
    {
        //Definir la clase derivada Gerente:
        //Crear la clase Gerente que herede de Empleado.
        //Agregar el atributo NumeroEmpleados.
        //Implementar el método Trabajar() para que imprima "El gerente está gestionando el departamento."
        //Sobrescribir CalcularBonificacion() para calcular una bonificación específica para gerentes, los gerentes reciben una bonificacion del 25% del salario.
        //Implementar el método Planificar(), es retorna un string que informara que el gerente es creando una planificacion para la cantidad de empleados que tenga a cargo.
        //Implementar el método SalarioTotal().

        protected int numeroEmpleados;

        public Gerente(string nombre, double salario, string departamento, int antiguedad, int numeroEmpleados)
            :base(nombre, salario, departamento, antiguedad)
        {        
            this.numeroEmpleados = numeroEmpleados;
        }

        public override string Trabajar()
        {
            return "El gerente trabaja";
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo} - Numero de Empleados: {numeroEmpleados}";
        }

        public override double CalcularBonificacion()
        {          
            return salario * 0.25;
        }

        public override double SueldoTotal()
        {
            return salario + CalcularBonificacion();
        }

        public string Planificar()
        {
            return $"El gerente esta creando una planificacion para sus {numeroEmpleados} empleados";
        }
    }
}
