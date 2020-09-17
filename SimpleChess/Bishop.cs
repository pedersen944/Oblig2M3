using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
     class Bishop : Piece
    {
        

        public override bool Move(string fromPosition, string toPosition)
        {
            var colMove = fromPosition[0] - toPosition[0];
            var rowMove = fromPosition[1] - toPosition[1];
            return Math.Abs(colMove) == Math.Abs(rowMove);
        }

        public Bishop(string symbol = "LPR") : base(symbol)
        {
        }
    }


}
