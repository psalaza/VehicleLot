using System;

namespace VehicleLot
{
    class Car : Vehicle{
        public string color;
        public int numOfDoors;

        public Car(string _make, string _model,string _color, int _numOfDoors){
            make = _make;
            model = _model;
            color = _color;
            numOfDoors = _numOfDoors;
        }

        public void print(){
            printVehicle();
            Console.WriteLine("color: " + color + ", number of doors: " + numOfDoors);
        }
    }

}