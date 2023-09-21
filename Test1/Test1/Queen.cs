using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Queen: Figures
    {
        
        private new int xPos;
        private new int yPos;
        public virtual int NewQueenX 
        { 
            get { return xPos; }
        }
        public virtual int NewQueenY 
        {
            get { return yPos; }
        }
        
        public Queen(string name, string symbol, int xPos, int yPos) : base(name, symbol)
        {
            this.xPos = 7;
            this.yPos = yPos;
        }

        public override void Hod()
        {
            Console.WriteLine("Куда переместить ферзя?");
            bool checkX = int.TryParse(Console.ReadLine(), out xPos);
            bool checkY = int.TryParse(Console.ReadLine(), out yPos);
            if(checkX && checkY == false) 
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if (NewQueenX < 0 || NewQueenX > 7 || NewQueenY < 0 || NewQueenY > 7)
            {
                Console.WriteLine("Конец поля, повторите попытку");
            }
            else if(Math.Abs(xPos - NewQueenX) == Math.Abs(yPos - NewQueenY) ||
                Math.Abs(xPos + NewQueenX) == Math.Abs(yPos + NewQueenY) ||
                this.xPos == NewQueenX && NewQueenY > this.yPos ||
                this.xPos == NewQueenX && NewQueenY < this.yPos ||
                this.yPos == NewQueenY && NewQueenX > this.xPos ||
                this.yPos == NewQueenY && NewQueenX < this.xPos
                )
            {
                this.xPos = NewQueenX;
                this.yPos = NewQueenY;
            }
            else
            {
                Console.WriteLine("Ферзь не может так ходить");
            }
        }
    }
}
