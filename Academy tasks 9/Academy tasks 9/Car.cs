using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    internal class Car : Vehicle
    {
        public double CurrentFuel;
        public double FuelFor1km;
        public override void Drive(double km)
        {
            Mileage += km;
            CurrentFuel -= FuelFor1km * km;
        }
    }
}
