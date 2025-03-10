using System;
using System.Collections.Generic;


namespace ExpresionesLambdasYExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas persona1 = new Personas();
            persona1.Nombre = "ana";
            persona1.Edad = 43;

            Personas persona2 = new Personas();
            persona2.Nombre = "juan";
            persona2.Edad = 38;
            
            CompararEdad compararEdad = (edad1,edad2) => edad1 == edad2;
            Console.WriteLine(compararEdad(persona1.Edad,persona2.Edad));
            CompararNombres compararNombre = (nombre1,nombre2) => nombre1 == nombre2;
            Console.WriteLine(compararNombre(persona1.Nombre,persona2.Nombre));

            OperacionesMatematicasUnNumero cuadrado = numero => numero * numero;
            OperacionesMatematicasDosNumeros suma = new OperacionesMatematicasDosNumeros((numero1, numero2) => numero1 + numero2);
            Console.WriteLine(cuadrado(9));
            Console.WriteLine(suma(15, 35));

            List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
            List<int> numerosImpares = numeros.FindAll(numero => numero % 2 != 0);
            foreach (int item in numerosPares) Console.WriteLine(item);
            numerosImpares.ForEach(numero => Console.WriteLine(numero));
            numerosImpares.ForEach(numero => { Console.Write("El número impar es: ") ; Console.WriteLine(numero); });

        }
        delegate bool CompararEdad(int edad1,int edad2);
        delegate bool CompararNombres(string nombre1,string nombre2);
        delegate int OperacionesMatematicasUnNumero(int numero);
        delegate int OperacionesMatematicasDosNumeros(int numero1, int numero2);
        ////static int Cuadrado(int numero)
        ////{
        ////    return numero * numero;
        ////}
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
