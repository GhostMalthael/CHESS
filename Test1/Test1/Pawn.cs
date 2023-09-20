using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Pawn: Figures
    {
        public int newPawnX;
        public int newPawnY;
        public bool MoveFirst { get; private set; }
        public int NewPawnX
        {
            get { return newPawnX; }
            set { newPawnX = value; }
        }
        public int NewPawnY
        {
            get { return newPawnY; }
            set { newPawnY = value; }
        }
        public Pawn(string name, string symbol, int xPos, int yPos, Chess chess): base(name, symbol, xPos,yPos)
        {
            MoveFirst = true;
        }
        public void Hod()
        {
            bool secondX = int.TryParse(Console.ReadLine(), out newPawnX);
            bool secondY =int.TryParse(Console.ReadLine(),out newPawnY);
            
            if (secondX == false && secondY == false)
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if(MoveFirst == true && newPawnX == Math.Abs(this.xPos - 1) || newPawnX == Math.Abs(this.xPos - 2))
            {
                this.xPos = newPawnX;
                this.yPos = newPawnY;
                MoveFirst = false;
            }
            else if(MoveFirst == false && newPawnX == Math.Abs(this.xPos - 1))
            {
                this.xPos = newPawnX;
                this.yPos = newPawnY;
            }
        }
    }
}
