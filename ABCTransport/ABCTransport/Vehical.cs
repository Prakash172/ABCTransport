using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTransport
{
    abstract class Vehicle
    {
        private int _biilID { get; set; } = 1001;
        private char _fuelType;
        private String _vehicalMake;
        private String _vehicalType;
        private int _noOfKilometer;
        protected float ratePerKiloMeter;
        private static int _counter = 0;

        public Vehicle(char fuelType, String vehicalMake, String vehicalType,int noOfKiloMeter)
        {
            _biilID += _counter++;
            _fuelType = fuelType;
            _vehicalMake = vehicalMake;
            _vehicalType = vehicalType;
            _noOfKilometer = noOfKiloMeter;
        }

        public int getBillID()
        {
            return _biilID;
        }
        public char getFuelType()
        {
            return _fuelType;
        }
        public String getVehicalMake()
        {
            return _vehicalMake;
        }
        public String getVehicalType()
        {
            return _vehicalType;
        }
        public int getNoOfKiloMeter()
        {
            return _noOfKilometer;
        }
        public float getRatePerKiloMeter()
        {
            return ratePerKiloMeter;
        }
        public void validateFuelType()
        {
            if (this.getFuelType() != 'D' && this.getFuelType() != 'P')
            {
                Console.WriteLine("Invalid fuel type, set the value to D");
                _fuelType = 'D';
            }
        }

        public abstract void calculateRatePerKiloMeter();
        public abstract double calculateBill();


    }
}
