using System;
using tabuleiro;
using xadrez;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new('a', 1);
            Console.WriteLine(posicao);

            Console.WriteLine(posicao.ToPosicao());
        }
    }
}