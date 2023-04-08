using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Classes
{
    public class Bike
    {
        public enum Type { Electric, Mountain, Unicycle}
        string _brand;
        Type _type;
        string _Color;
        int _NumberOfWheels;

        public Bike(string brand, Type type, string color, int numberOfWheels)
        {
            _brand = brand;
            _type = type;
            _Color = color;
            _NumberOfWheels = numberOfWheels;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public Type Type1 { get => _type; set => _type = value; }
        public string Color { get => _Color; set => _Color = value; }
        public int NumberOfWheels { get => _NumberOfWheels; set => _NumberOfWheels = value; }

        public override string ToString()
        {
            return $"Bike Brand: {_brand}  \nBike Type: {_type}  \nBike Color: {_Color} \nNumber of Wheels: {_NumberOfWheels}\n";
        }
    }
}
