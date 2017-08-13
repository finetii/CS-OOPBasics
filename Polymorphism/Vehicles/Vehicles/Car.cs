﻿using System;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuelQty, double fuelConsumption, double tankCapacity)
            : base (fuelQty, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += 0.9;
        }

        public override void Drive(double distance)
        {
            if ((distance * this.FuelConsumption) <= this.FuelQty)
            {
                this.FuelQty -= distance * this.FuelConsumption;
            }
            else
                throw new ArgumentException("Car needs refueling");
        }
    }
}
