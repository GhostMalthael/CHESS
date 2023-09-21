using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Horse: Figures
    {
        private new int xPos;
        private new int yPos;
        public int NewHorseX
        {
            get { return xPos; }
        }
        public int NewHorseY
        {
            get { return yPos; }

        }
        public Horse(string name, string symbol, int xPos,int yPos) : base(name, symbol)
        {
            this.xPos = 7;
            this.yPos = 1;
        }
        public override void Hod()
        {
            Console.WriteLine("куда переместить коня?");
            bool checkX = int.TryParse(Console.ReadLine(), out xPos);
            bool checkY = int.TryParse(Console.ReadLine(), out yPos);
            if (checkX == false && checkY == false)
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            else if ( NewHorseX < 0 || NewHorseX > 7 || NewHorseY < 0 || NewHorseY > 7)
            {
                Console.WriteLine("Конец поля, повторите попытку");
            }
            else if (NewHorseX == xPos + 2 && NewHorseY == yPos + 1 ||
                NewHorseX == xPos + 2 && NewHorseY == yPos - 1 ||
                NewHorseX == xPos - 2 && NewHorseY == yPos + 1 ||
                NewHorseX == xPos - 2 && NewHorseY == yPos - 1 ||
                NewHorseX == xPos - 1 && NewHorseY == yPos + 2 ||
                NewHorseX == xPos - 1 && NewHorseY == yPos - 2 ||
                NewHorseX == xPos + 1 && NewHorseY == yPos + 2 ||
                NewHorseX == xPos + 1 && NewHorseY == yPos - 2)
            {
                xPos = NewHorseX;
                yPos = NewHorseY;
            }
            else
            {
                Console.WriteLine("Конь может ходить только буковкой Г");
            }
        }
    }
}
