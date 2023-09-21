using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Rook : Figures
    {
        private new int xPos;
        private new int yPos;
        public int NewRookX
        {
            get { return xPos; }
        }
        public int NewRookY
        {
            get { return yPos; }
        }
        public Rook(string name, string symbol, int xPos, int yPos) : base(name, symbol)
        {
            this.xPos = 7;
            this.yPos = yPos;
        }
        public override void Hod()
        {
            Console.WriteLine("Куда переместить ладью");
            bool secondX = int.TryParse(Console.ReadLine(), out xPos);
            bool secondY = int.TryParse(Console.ReadLine(), out yPos);
            if(secondX && secondY == false)
            {
                Console.WriteLine("Вы не выбрали поля или указан неверный формат, повторите попытку:");
            }
            //else if(this.xPos == NewRookX && NewRookY > this.yPos||
            //    )
        }
    }
}
