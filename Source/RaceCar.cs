using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class RaceCar : Car
    {
        public RaceCar(string Name = " ") : base()
        {
            Name = Name;
        }
        private const int MAX_VELOCITY = 200;
        private const int MIN_VELOCITY = 50;

        public int Velocity { get; private set; }

        public override void FollowVelocity()
        {
            Random chance = new Random();
            Velocity = chance.Next(MIN_VELOCITY, MAX_VELOCITY);
        }

    }
}
