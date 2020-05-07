using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Passport : AbstractShow
    {
        public int seria;
        public int number;
        public Passport(int _seria, int _number)
        {
            seria = _seria;
            number = _number;
        }
        public override string show()
        {
            return $"{seria} {number}";
        }
    }
}
