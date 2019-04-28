using System;
using System.Collections.Generic;
using System.Collections;

namespace car_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>(){
                "Camry", "Aztek", "Charger", "Space Car", "Aztek"
            };

            HashSet<string> usedLot = new HashSet<string>(){
                "Jaguar", "Edsel"
            };

            HashSet<string> cars = new HashSet<string>(usedLot);

            cars.UnionWith(showRoom);
            Console.WriteLine(cars.Count);

            cars.Remove("Edsel");
            Console.WriteLine(cars.Count);

            HashSet<string> junkYard = new HashSet<string>(){
                "Impala", "Ram"
            };
            HashSet<string> clone = new HashSet<string>(showRoom);
            HashSet<string> junkCars = new HashSet<string>(junkYard);

            showRoom.IntersectWith(clone);
            junkYard.IntersectWith(clone);
            junkCars.UnionWith(clone);

            foreach(string singleClone in junkCars){
            Console.WriteLine(singleClone);
            }
        }
    }
}
