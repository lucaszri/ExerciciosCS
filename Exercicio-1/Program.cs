namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Calcule as expressões abaixo, observando a precedência dos operadores. Escreva um programa que mostre na tela o resultado de cada expressão e confira seus cálculos.
                26 + 115 =
                20/(-2)/5 =
                20/22 =
                (3+9)/34 =
                (56/(3+2) - 154)/6-4 =
                4+322 -72/(9-2) =
             */

            int a = 26 + 115;
            Console.WriteLine("26 + 115 = " + a);

            int b = 20 / (-2) / 5;
            Console.WriteLine("20/(-2)/5 = " + b);

            double c = (double)20 / 22;
            Console.WriteLine("20/22 = " + c);

            double d = (double)(3 + 9) / 34;
            Console.WriteLine("(3+9)/34 = " + d);

            double e = (double)(56 / (3 + 2) - 154) / 6 - 4;
            Console.WriteLine("(56/(3+2) - 154)/6-4 = " + e);

            double f = (double)4 + 322 - 72 / (9 - 2);
            Console.WriteLine("4+322 -72/(9-2) = " + f);
        }
    }
}