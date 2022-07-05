using System;
using System.Collections.Generic;

namespace ClassesEx
{
    public class Car

    {





        public Car(string makeInput, string modelInput, int yearInput)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        var chevy = new Car { "Chevy", "Impala", 2001 };

        var carList = new List<Car>() { myCar, mazda, chevy, new Car(), new Car() };
        private string make;
        private string model;
        private int year;

        Console.WriteLine(List.Capacity);
    }
}
