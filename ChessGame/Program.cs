using ChessGame.tabuleiro;
using System;
using System.Collections.Generic;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}

