using System;


namespace Gastos.Services
{
    public class GastoService
    {
        public void adicaoGasto()
        {
            Console.WriteLine("Qual valor você deseja adicinoar?");
            int gasto = int.Parse(Console.ReadLine() ?? "");
        }
    }
}