using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Classes
{
    public class Car
    {
        //        string _make;
        //        string _model;
        //        int _year;
        //        string _color;
        //        int _mileage;
        //        Properties

        //string Make
        //        {
        //            get => _make; set => { _make = value; }
        //string Model
        //        {
        //            get => _model; set => { _model = value; }
        //int Year
        //        {
        //            get => _year; set => { _year = value; }
        //string Color
        //        {
        //            get => _color; set => { _color = value; }
        //int Mileage
        //        {
        //            get => _mileage; set => { _mileage = value; }
        //            Test your class out

        //Create an instance of Car in the main window.Then display the make, model, year, color, and mileage when your app runs.
        string _make;
        string _model;
        int _year;
        string _color;
        int _mileage;

        public string Make
        {
            get => _make;
            set => _make = value;
        }
        public string Model
        {
            get => _model;
            set => _model = value;
        }
        public int Year
        {
            get => _year;
            set => _year = value;
        }
        public string Color
        {
            get => _color; 
            set => _color = value;
        }
        public int Mileage
        {
            get => _mileage; 
            set => _mileage = value;
        }
        public override string ToString()
        {
            return $"Car Brand: {_make} \nCar Model: {_model} \nYear: {_year}   \nColor: {_color} \nMileage: {_mileage}\n";
        }
    }
}
