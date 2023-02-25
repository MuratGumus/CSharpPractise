using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0021_ClassCarDoorColour
{
    internal class Program
    {

        // Class ile belirenen tanımlamalar konsola yazdırılıyor. 
        static void Main(string[] args)
        {
            Car car = new Car(); // Yeşil ile yazılı olan "car", class olan "car", maviyle yazılı olan "car" variable olan "car"dır.

            car.howManyDoor = 4;
            car.carColour = "Red";
            car.carModel = "Ferrari";
            

            car.closeDoor(); // class içerisindeki kodu çalıştırdı. cw  yazdırdı.
            car.startEngine(); // class içerisindeki kodu çalıştırdı. cw  yazdırdı.

            Console.WriteLine("There are " + car.howManyDoor + " doors");
            Console.WriteLine("Car's colour is " + car.carColour);
            Console.WriteLine("Car's model is " + car.carModel);
            Console.ReadLine();
        }
    }
}
