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

            OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);
            Console.WriteLine(operacion(9));
        }

        delegate int OperacionesMatematicas(int numero);
        static int Cuadrado(int numero)
        {
            return numero * numero;
        }
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
