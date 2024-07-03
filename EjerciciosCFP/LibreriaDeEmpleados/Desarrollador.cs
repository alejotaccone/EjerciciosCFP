using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Desarrollador : Empleado
    {
        //Definir la clase derivada Desarrollador:
        //Crear la clase Desarrollador que herede de Empleado.
        //Agregar los atributos LenguajeProgramacion y Experiencia.
        //Implementar el método Trabajar() para que imprima "El desarrollador está escribiendo código."
        //Sobrescribir CalcularBonificacion() para calcular una bonificación específica para desarrolladores,
        //los desarrolladores reciben una bonificacion del 15% del salario.
        //Implementar el método DepurarCodigo(), debe informar que esta depurando el codigo escrito en un su lenguaje
        //de programacion.
        //Implementar el método SalarioTotal().
        protected string lenguajeProgramacion;
        protected string experiencia;

        public Desarrollador(string nombre, double salario, string departamento, int antiguedad, string lenguajeProgramacion, string experiencia)
            : base(nombre, salario, departamento, antiguedad)
        {
            this.lenguajeProgramacion= lenguajeProgramacion;
            this.experiencia = experiencia;
        }

        public override string Trabajar()
        {
            return "El desarrollador está escribiendo código.";
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo} - Lenguaje de programacion: {lenguajeProgramacion} - Experiencia: {experiencia}";
        }

        public override double CalcularBonificacion()
        {
            return salario*0.15;
        }

        public override double SueldoTotal()
        {
            return salario + CalcularBonificacion();
        }

        public string DepurarCodigo()
        {
            return $"El desarrollador esta depurando el codigo escrito en {lenguajeProgramacion}.";
        }
    }
}
