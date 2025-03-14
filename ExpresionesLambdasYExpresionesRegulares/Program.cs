using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ExpresionesLambdasYExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expresiones regulares
            string frase = "Mi nombre es Ana y mi número de teléfono es (+54)9 4123-1235 y mi código postal es 5263 y mi otro número es (+23) 4414-5555";
            //Si hay A mayúscula y minúscula
            string patron = @"\d{2}";//@"\d", @\d{3}, [^mnM], [A-Z],[a-z],[0-9],1|t;
            Regex expReg = new Regex(patron);
            MatchCollection matchCollection = expReg.Matches(frase);
            if (matchCollection.Count > 0) Console.WriteLine($"Se ha encontrado {matchCollection.Count} coincidencia/s");
            else Console.WriteLine("No se ha encontrado ninguna coincidencia");

            //Expresiones Lambda
            //Personas persona1 = new Personas();
            //persona1.Nombre = "ana";
            //persona1.Edad = 43;

            //Personas persona2 = new Personas();
            //persona2.Nombre = "juan";
            //persona2.Edad = 38;
            
            //CompararEdad compararEdad = (edad1,edad2) => edad1 == edad2;
            //Console.WriteLine(compararEdad(persona1.Edad,persona2.Edad));
            //CompararNombres compararNombre = (nombre1,nombre2) => nombre1 == nombre2;
            //Console.WriteLine(compararNombre(persona1.Nombre,persona2.Nombre));

            //OperacionesMatematicasUnNumero cuadrado = numero => numero * numero;
            //OperacionesMatematicasDosNumeros suma = new OperacionesMatematicasDosNumeros((numero1, numero2) => numero1 + numero2);
            //Console.WriteLine(cuadrado(9));
            //Console.WriteLine(suma(15, 35));

            //List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            //List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
            //List<int> numerosImpares = numeros.FindAll(numero => numero % 2 != 0);
            //foreach (int item in numerosPares) Console.WriteLine(item);
            //numerosImpares.ForEach(numero => Console.WriteLine(numero));
            //numerosImpares.ForEach(numero => { Console.Write("El número impar es: ") ; Console.WriteLine(numero); });

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
