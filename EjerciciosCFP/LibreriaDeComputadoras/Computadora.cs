using System.Drawing;
using System;

namespace LibreriaDeComputadoras
{

    // Constructor privado que solo instancia la lista de programas.
    // Constructor público que asigna valores a todos sus campos excepto a la lista de programas.
    // Método get que retorna la lista de programas.
    // Método set que se encarga de agregar un programa a la lista.
    // Método static ListadoDeProcesadores() que retorna una lista de al menos 5 tipos de procesadores.
    // Todas las propiedades son de solo lectura y retornan el valor de los atributos que hacen referencia, excepto Programas, esta propiedad retorna un string con todos los nombres de los programas concatenados.
    
    // Tipos de atributos:
    // INT: memoriaRam, capacidadDisco.
    // STRING: procesador, sistemaOperativo.
    // LIST<string>: programas.
    public class Computadora
    {
        int memoriaRam;
        int capacidadDisco;
        string procesador;
        string sistemaOperativo;
        List<string> programas;

        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
        public List<string> Programas { get => programas; }

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo)
            : this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
        }

        public void SetPrograma(string programa)
        {
            programas.Add(programa);
        }

        public List<string> GetProgramas()
        {
            return Programas;
        }

        public static List<string> ListadoDeProcesadores()
        {
            List<string> listaProcesadores = new List<string> { "I9", "I7", "I10", "I5", "I3" };

            return listaProcesadores;
        }
    }
}
