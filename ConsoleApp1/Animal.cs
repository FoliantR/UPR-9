using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Animal : AbstractShow
    {
        public string kind;
        public int age;
        public string name;
        public string color;
        public Animal(string _king, int _age, string _name, string _color)
        {
            kind = _king;
            age = _age;
            name = _name;
            color = _color;
        }
        public override string show()
        {
            return $"{kind} {age} {name} {color}";
        }
    }
}
