using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class AlexKavanaugh : Driver
    {
        public AlexKavanaugh(RaceCar car) : base(car)
        {
            Name = "Alex Kavanaugh";
            SkillLevel = 11;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}