using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPaarkingBill
{
    class vehicles
    {
        private double rentDue = 0;
        protected int minimumFeeIf3hours = 0;
        protected double chargePerAdditioanlHour = 0;
        protected double maximumChargeforwholeday = 0;
        protected double additioanlHours = 0;
        //double 
        public vehicles()
        {

        }
        public double calculateRent(int hours)
        {
            if (hours<=3)
            {
                rentDue = minimumFeeIf3hours;
                return rentDue;
            }
            else
            {
                additioanlHours = hours - 3;
                rentDue = (additioanlHours* chargePerAdditioanlHour) + minimumFeeIf3hours;
                if (rentDue > maximumChargeforwholeday)
                {
                    rentDue = maximumChargeforwholeday;
                    return rentDue;
                }
                else 
                    return rentDue;
            }

        }
    }
    class Buses:vehicles
    {
        public Buses()
        {
           minimumFeeIf3hours = 2;
           chargePerAdditioanlHour = 0.50;
           maximumChargeforwholeday = 10;
        }
    }
    class Bikes:vehicles
    {
        public Bikes()
        {
            minimumFeeIf3hours = 6;
            chargePerAdditioanlHour = 1.50;
            maximumChargeforwholeday = 30;
        }
    }
    class Cars:vehicles
    { 
        public Cars()
        {
            minimumFeeIf3hours = 4;
            chargePerAdditioanlHour = 1;
            maximumChargeforwholeday = 20;
        }
    }
}
