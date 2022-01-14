using System;


namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void delegateCalculadora();
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição: (x + y)");
        }
        public void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: (x - y)");
        }
    }
}