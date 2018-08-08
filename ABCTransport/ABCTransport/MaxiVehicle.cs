using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTransport
{
    class MaxiVehicle : Vehicle
    {
        private float _loadInKg;
        private float _ratePerKg;
        public MaxiVehicle(char FuelType, String VehicalMake, String VehicalType, int NoOfKiloMeter, float loadInKG) : base(FuelType,VehicalMake,VehicalType,NoOfKiloMeter)
        {
            _loadInKg = loadInKG;
        }
        public float getLoadInKg()
        {
            return _loadInKg;
        }

        public float getRatePerKg()
        {
            return _ratePerKg;
        }
        public bool validatLoadInKG()
        {
            if (getLoadInKg() < 5000 && getLoadInKg() > 1000)
                return true;
            else
                return false;
            
        }
        public void calculateRatePerKG()
        {
            if (getVehicalMake().Equals("Ashok Leyland"))
                _ratePerKg = 1.5f;
            else if (getVehicalMake().Equals("Mahindra"))
                _ratePerKg = 1.0f;
            else _ratePerKg = 0.5f;

        }
        public override void calculateRatePerKiloMeter()
        {
            if (getFuelType() == 'P') ratePerKiloMeter = 6;
            else ratePerKiloMeter = 5;
        }


        public override double calculateBill()
        {
            if(!validatLoadInKG())
            {
                Console.WriteLine("Unable to calculate the bill as the entered loadInKG is incorrect");
                return 0.0;
            }
            else
            {
                return getNoOfKiloMeter() * ratePerKiloMeter + getLoadInKg() * getRatePerKg();
            }

        }
    }
}
