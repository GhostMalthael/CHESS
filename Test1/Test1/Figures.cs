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
        private string symbol;
        public int xPos;
        public int yPos;
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public Figures(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }
        public abstract void Hod();
    }
}
