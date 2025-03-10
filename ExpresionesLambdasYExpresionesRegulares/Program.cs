using System;


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

            OperacionesMatematicasUnNumero cuadrado = new OperacionesMatematicasUnNumero(numero => numero * numero);
            OperacionesMatematicasDosNumeros suma = new OperacionesMatematicasDosNumeros((numero1,numero2) => numero1 + numero2);
            Console.WriteLine(cuadrado(9));
            Console.WriteLine(suma(15,35));
        }

        delegate int OperacionesMatematicasUnNumero(int numero);
        delegate int OperacionesMatematicasDosNumeros(int numero1, int numero2);
        //static int Cuadrado(int numero)
        //{
        //    return numero * numero;
        //}
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
