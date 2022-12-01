using ChessGame.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.xadrez
{
    internal class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez() {

        }
        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString() {
            return "" + linha +  coluna;
        }

        public Posicao toPosicao() {
            return new Posicao(8-linha, coluna - 'a');
        }
    }
}
