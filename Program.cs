using System;


namespace Gastos
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("==== CONTROLE DE GASTO =====");
            Console.WriteLine("1 - Adicionar gasto");
            Console.WriteLine("2 - Listar gastos");
            Console.WriteLine("3 - Buscar gasto");
            Console.WriteLine("4 - Remover gasto");
            Console.WriteLine("5 - Ver total gasto");
            Console.WriteLine("6 - Ver maior gasto");
            Console.WriteLine("7 - Relatório por categória");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            int menu = int.Parse(Console.ReadLine() ?? "");


            switch (menu)
            {
                case 1:
                  
                break;
            }



        }
    }
}