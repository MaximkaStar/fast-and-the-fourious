using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Car
    {
        public delegate void End(Car machine);
        public abstract class Machine
        {
            public Machine()
            {
                Stance = 0;
                FollowVelocity();
            }
            protected const int MIN_VELOCITY = 50;
            private const int END_SIDE = 1000;

            public event End Winning;
            public int Velocity { get; set; }
            public int Post { get; set; }
            public string Title { get; set; }
            public int Stance { get; private set; }

            public abstract void FollowVelocity();

            public bool Way()
            {
                Post += Velocity;
                FollowVelocity();
                if (Post >= END_SIDE)
                {
                    Winning(machine: Car);
                }
                else return false;

            }

            public override string ToString()
            {
                return string.Format(": {0,5}, Post: {0, -5}", Title,Post);
            }

        }

        internal bool Drive()
        {
            throw new NotImplementedException();
        }
    }
}
