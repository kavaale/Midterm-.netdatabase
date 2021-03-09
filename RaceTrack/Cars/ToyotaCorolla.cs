using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ToyotaCorolla : RaceCar
    {
        public ToyotaCorolla()
        {
            Name = "Toyota Corolla";
            TopSpeed = 200;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The engine of the {Name} sputters to life.");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} powers down.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} slows down easily to a stop.");
            base.Brake();
        }
    }
}