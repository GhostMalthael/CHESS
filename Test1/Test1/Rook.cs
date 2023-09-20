using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Rook : Figures
    {
        Chess chess;
        int newRookX;
        int newRookY;
        public int NewRookX
        {
            get { return newRookX; }
            set { newRookX = value; }
        }
        public int NewRookY
        {
            get { return newRookY; }
            set { newRookY = value; }
        }
        public Rook(string name, string symbol, int xPos, int yPos, Chess chess) : base(name, symbol, xPos, yPos)
        {
            this.chess = chess;
        }
        public void MoveRook()
        {
            Console.WriteLine("Куда переместить ладью");
            bool secondX = int.TryParse(Console.ReadLine(), out newRookX);
            bool secondY = int.TryParse(Console.ReadLine(), out newRookY);
            if(secondX && secondY == false)
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if(this.xPos == newRookX && newRookY > this.yPos||
                )
        }
    }
}
