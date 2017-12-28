using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Source.Car;
using static System.Console;

namespace Source
{
    public class Drive
    {
        public List<Car> Machine { get; private set; }

        private End end = Car =>
         {
             WriteLine("Win: " + Machine.Name);
         };
        public Drive()
        {
            Machine = new List<Car>();
        }
        public bool DriveAll()
        {
            for (int j = 0, j < Machine.Count; j++)
            {
                if(Machine[j].Drive())
                {
                    WriteLine("END!");
                    Reload();
                    return true;
                }
            }
            return false;
        }

        private void Reload()
        {
            Machine.Clear();
        }

        public void StartDrive()
        {
            Machine.ForEach(machine => Machine.Winning += End);
        }
    }
}
