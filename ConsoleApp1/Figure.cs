using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Figure : AbstractShow
    {
        public string name;
        public string color;
        public int square;
        public Figure(string _name, string _color, int _square)
        {
            name = _name;
            color = _color;
            square = _square;
        }
        public override string show()
        {
            return $"{name} {color} {square}";
        }
    }
}
