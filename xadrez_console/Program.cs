using System;
using System.Globalization;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new tabuleiro.Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();
        }
    }
}
