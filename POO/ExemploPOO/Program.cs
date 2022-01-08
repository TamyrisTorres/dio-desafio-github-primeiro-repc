using System;
using ExemploPOO.Models;
using static ExemploPOO.Models.Pessoa;
using static ExemploPOO.Models.Aluno;


namespace ExemploPOO

{
    class Program
    {
        static void Main(string[] args)
        {

            Computador c = new Computador();
            System.Console.WriteLine(c.ToString());

            //Corrente c = new Corrente();
            //c.Creditar(100);

            //c.ExibirSaldo();

            //Calculadora calc = new Calculadora();
            //System.Console.WriteLine("Resultatdo da primeira soma: " + calc.Somar(10, 10));
            //System.Console.WriteLine("Resultatdo da segunda soma: " + calc.Somar(10, 10, 10));
            
            //Aluno p1 = new Aluno();
            //p1.Nome = "Bob";
            //p1.Idade = 20;
            //p1.Documento = "123456";
            //p1.Apresentar();

           //Professor p2 = new Professor();
           //p2.Nome = "Miguel";
           //p2.Idade = 22;
           //p2.Documento = "123456";
           //p2.Salario = 3000;
           //p2.Apresentar();
        }
    }
}
