using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTransport
{
    class MiniVehical : Vehicle
    {
        private int _seatingCapacity;
        public MiniVehical(char FuelType, String VehicleMake, String VehicleType, int noOfKiloMeter, int seatingCapacity) : base(FuelType, VehicleMake, VehicleType, noOfKiloMeter)
        {
            _seatingCapacity = seatingCapacity;
        }

        public override void calculateRatePerKiloMeter()
        {
            ratePerKiloMeter = 4.5f + (_seatingCapacity - 4) * 1;
        }

        public override double calculateBill()
        {
           return getNoOfKiloMeter()*ratePerKiloMeter;
        }

        public int getSeatingCapacity()
        {
            return 0;
        }
       
    }
}
