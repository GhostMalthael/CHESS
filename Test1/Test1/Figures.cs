using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    abstract class Figures
    {
        public string name;
        public string symbol;
        public int xPos;
        public int yPos;
        public Figures(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }
        public abstract void Hod();
    }
}
