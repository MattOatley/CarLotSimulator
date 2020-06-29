using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Honk { get; set; }
        public bool isDriveable { get; set; }


        public Car()
        {

        }


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = false)
    {
            Year = year;
            Make = make;
            Model = model;
            Engine = engineNoise;
            Honk = honkNoise;
    }
        public void MakeEngineNoise()
        {
            Console.WriteLine($"Engine noise goes {Engine}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"Horn noise goes {Honk}");
        }
        
    }
}
