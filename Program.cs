using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            do
            {
                Console.WriteLine("Informe o Valor:");
                valor = double.Parse(Console.ReadLine());
            }
            while (valor < 0);
            Console.WriteLine("Valor: {0} Aceito!", valor);
        }
    }
}
