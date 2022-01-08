using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {

        public Double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor e tenho um salário de R${Salario}");
        }
        
    }
}