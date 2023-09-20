using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    abstract class Figures
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string symbol;
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
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
