using ChessGame.tabuleiro;
using System.Runtime.ConstrainedExecution;

namespace ChessGame.xadrez
{
    internal class Torre : Peca
    {
        public Torre( Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "T";
        }
    }
}
