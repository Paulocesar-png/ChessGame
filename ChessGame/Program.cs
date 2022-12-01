using ChessGame.tabuleiro;
using ChessGame.xadrez;
using System;
using System.Collections.Generic;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args) {
            try {
      
            PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            } catch (TabuleiroExecption e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

