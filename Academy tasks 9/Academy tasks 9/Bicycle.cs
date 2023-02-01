using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}
