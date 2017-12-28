using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class DragCar : Car
    {
        public DragCar(string nick = " ") : base()
        {
            nick = nick;
        }

        private const int MAX_VELOCITY = 600;
        private const int MIN_VELOCITY = 1;

        public int Velocity { get; private set; }

        public override void FollowVelocity()
        {
            Random chance = new Random();
            Velocity = chance.Next(MIN_VELOCITY, MAX_VELOCITY);
        }
    }
}
