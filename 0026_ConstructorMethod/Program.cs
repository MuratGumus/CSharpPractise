using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0026_ConstructorMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int howManyDoor = 4;
            string carColour = "Red";
            string carModel = "Ferrari";

            Car car1 = new Car(howManyDoor, carModel,  carColour);


            Console.WriteLine("There are " + howManyDoor + " doors");
            Console.WriteLine("Car's colour is " + carColour);
            Console.WriteLine("Car's model is " + carModel);

            car1.closeDoor();
            car1.startEngine();


            Console.ReadLine();
        }

    }
}
