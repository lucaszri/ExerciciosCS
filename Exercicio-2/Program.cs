using System.Runtime.Serialization;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Multiplicação rápida - Um algoritmo para multiplicação rápida por 11 de números de 2 dígitos funciona assim: para multiplicar 81 x 11, 
                some os dígitos do número (8 + 1 = 9) e insira o resultado entre os dígitos (891). 
                Se a soma der maior que 9, incremente o dígito da esquerda: 56 x 11 = 616. 
                Faça um programa que efetue multiplicações por 11 usando este algoritmo.
            */

            Console.WriteLine("Digite um número de dois dígitos para ser multiplicado por 11:");
            string numero = Console.ReadLine();

            int ultimaPosicao = Int32.Parse(numero) % 10;
            Console.WriteLine(ultimaPosicao);

            int primeiraPosicao = Int32.Parse(numero) / 10;
            Console.WriteLine(primeiraPosicao);

            int soma = primeiraPosicao + ultimaPosicao;
            int soma2 = primeiraPosicao + ultimaPosicao;

            if (soma > 9) {
                soma2 = soma / 10;
                soma = soma % 10;
                primeiraPosicao = primeiraPosicao + soma2;  
            }

            Console.WriteLine($"O resultado de {numero} x 11 é = {primeiraPosicao}{soma}{ultimaPosicao}" );
         

        }
    }
}