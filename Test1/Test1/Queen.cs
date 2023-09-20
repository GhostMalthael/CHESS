using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Queen: Figures
    {
        Figures figures;
        Chess chess;
        int newQueenX;
        int newQueenY;
        public virtual int NewQueenX 
        { 
            get { return newQueenX; }
            set { newQueenX = value; }
        }
        public virtual int NewQueenY 
        {
            get { return newQueenY; }
            set { newQueenY = value; }
        }
        
        public Queen(string name, string symbol, int xPos, int yPos, Chess chess ) : base(name, symbol, xPos, yPos)
        {
            
            this.chess = chess;
        }

        public void MoveQueen()
        {
            Console.WriteLine("Куда переместить ферзя?");
            bool secondX = int.TryParse(Console.ReadLine(), out newQueenX);
            bool secondY = int.TryParse(Console.ReadLine(), out newQueenY);
            if(secondX && secondY == false) 
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if (newQueenX < 0 || newQueenX > 7 || newQueenY < 0 || newQueenY > 7)
            {
                Console.WriteLine("Конец поля, повторите попытку");
            }
            else if(Math.Abs(xPos - newQueenX) == Math.Abs(yPos - newQueenY) ||
                Math.Abs(xPos + newQueenX) == Math.Abs(yPos + newQueenY) ||
                this.xPos == newQueenX && newQueenY > this.yPos ||
                this.xPos == newQueenX && newQueenY < this.yPos ||
                this.yPos == newQueenY && newQueenX > this.xPos ||
                this.yPos == newQueenY && newQueenX < this.xPos
                )
            {
                this.xPos = newQueenX;
                this.yPos = newQueenY;
            }
            else
            {
                Console.WriteLine("Ферзь не может так ходить");
            }
        }
    }
}
