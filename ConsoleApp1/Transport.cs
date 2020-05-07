using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Transport : AbstractShow
    {
        public string type;
        public string car_brand;
        public string color;
        public Transport(string _type, string _car_brand, string _color)
        {
            type = _type;
            car_brand = _car_brand;
            color = _color;
        }
        public override string show()
        {
            return $"{type} {car_brand} {color}";
        }
    }
}
