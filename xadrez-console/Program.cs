using System;
using tabuleiro;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new(3, 4);
            Console.WriteLine(P);
        }
    }
}