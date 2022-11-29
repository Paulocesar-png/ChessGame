using ChessGame.tabuleiro;
using System.Runtime.ConstrainedExecution;

namespace ChessGame.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab,Cor cor) : base(tab,cor) {
        }

        public override string ToString() {
            return "R";
        }
    }
}
