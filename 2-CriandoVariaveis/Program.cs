﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proj 2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;

            Console.WriteLine(idade);

            idade = 10 + 5;

            Console.WriteLine(idade);

            idade = 10 + 5 * 2;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;

            Console.WriteLine("Sua idade e " + idade);

            Console.WriteLine("Exeucao finalizada. Aperte Enter para sair...");
            Console.ReadLine();
        }
    }
}
