using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0026_ConstructorMethod
{
    public class Car
    {
        public int howManyDoor;
        public string carModel;
        public string carColour;
        public Car(int door , string model , string colour)
        {
            howManyDoor = door;
            carModel = model;
            carColour = colour;
        }
     


        public void startEngine()
        {
            Console.WriteLine("Engine is active");
        }
        public void closeDoor()
        {
            Console.WriteLine("Door is close");
        }

       
    }
}
