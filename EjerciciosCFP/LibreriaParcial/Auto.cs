using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System;

namespace LibreriaParcial
{
    public class Auto
    {
        private string marca;
        private double cantCombustible;
        private string color;

        
        public Auto(string marca, double cantCombustible, string color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }


        public string GetMarca()
        {
            return marca;
        }

        public double GetCantCombustible()
        {
            return cantCombustible;
        }

        public string GetColor()
        {
            return color;
        }


        public string AutoToString()
        {
            return $"Marca: {marca}, Cantidad de Combustible: {cantCombustible}, Color: {color}";
        }


        public bool Avanzar(int cantKm)
        {
            double combustibleNecesario = (double)cantKm / 10;
            bool retorno = false;
            
            if (combustibleNecesario <= cantCombustible && cantCombustible > 0)
            {
                cantCombustible -= combustibleNecesario;
                retorno = true;
            }
            return retorno; 
            
        }

        public bool ConvertirStringEnComb(string combustible)
        {
            bool retorno = false;
            if (double.TryParse(combustible, out double combValido))
            {
                this.cantCombustible = combValido;
                retorno = true;
            }
            return retorno;
        }


        public static List<string> ColoresValidos()
        {
            List<string> list = new List<string>()
            {
                "Azul","Rojo","Verde","Amarillo","Gris"
            };
            return list;
        }


    }     
}
