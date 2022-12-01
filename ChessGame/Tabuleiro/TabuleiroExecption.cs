using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.tabuleiro
{
    internal class TabuleiroExecption : Exception
    {
        public TabuleiroExecption(string msg) : base (msg){
        
        }
    }
}
