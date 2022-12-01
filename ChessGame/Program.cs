﻿using ChessGame.tabuleiro;
using ChessGame.xadrez;
using System;
using System.Collections.Generic;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args) {
            try {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3,5));
            Tela.imprimirTabuleiro(tab);
            } catch (TabuleiroExecption e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

