using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person : AbstractShow
    {
        public string sex;
        public int age;
        public string name;
        public string zodiac;

        public Person(string _sex, int _age, string _name, string _zodiac)
        {
            sex = _sex;
            age = _age;
            name = _name;
            zodiac = _zodiac;
        } 
        public override string show()
        {
            return $"{sex} {age} {name} {zodiac}";
        }
    }
}
