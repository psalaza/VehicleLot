using System;

namespace VehicleLot
{
    class Vehicle{
        protected string make;
        protected string model;

        protected void printVehicle(){
            Console.WriteLine("make: " + make  + ", model: " + model);
        }
    }

}