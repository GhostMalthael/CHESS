using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Pawn: Figures
    {
        private new int xPos;
        private new int yPos;
        public bool MoveFirst { get; private set; }
        public int NewPawnX
        {
            get { return xPos; }
        }
        public int NewPawnY
        {
            get { return yPos; }
        }
        public Pawn(string name, string symbol, int xPos, int yPos): base(name, symbol)
        {
            this.xPos = 6;
            this.yPos = yPos;
            MoveFirst = true;
        }
        public override void Hod()
        {
            bool checkX = int.TryParse(Console.ReadLine(), out xPos);
            bool checkY =int.TryParse(Console.ReadLine(),out yPos);
            
            if (checkX == false && checkY == false)
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if(MoveFirst == true && NewPawnX == Math.Abs(this.xPos - 1) || NewPawnX == Math.Abs(this.xPos - 2))
            {
                this.xPos = NewPawnX;
                this.yPos = NewPawnY;
                MoveFirst = false;
            }
            else if(MoveFirst == false && NewPawnX == Math.Abs(this.xPos - 1))
            {
                this.xPos = NewPawnX;
                this.yPos = NewPawnY;
            }
        }
    }
}
