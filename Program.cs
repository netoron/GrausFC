using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string divisao;
            double total;
            double mais = 32;
            double menos = 1.8;
            double conteudo;
            
            Console.WriteLine("Digite a temperatura em °F para ser convertido em °C");
            divisao = Console.ReadLine();
            
            conteudo = Convert.ToDouble(divisao);

            total = conteudo - mais / menos;
            
            Console.WriteLine($"Conversão é {total}°F");
        }
    }
}
