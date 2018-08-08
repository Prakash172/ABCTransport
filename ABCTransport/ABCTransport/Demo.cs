using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTransport
{
    class Demo
    {
        public static MiniVehical getInitializeObjMini(String name)
        {
            MiniVehical mini = new MiniVehical('P', "Mazda", "car", 40, 7);
            mini.validateFuelType();
            mini.calculateRatePerKiloMeter();
            Console.WriteLine("Vehicle Type : {0}\n" +
                "Bill ID : {1}\n" +
                "Rate Per Kilometer : {2}\n" +
                "FuelType : {3}\n" +
                "Seating Capacity : {4}" , mini.getVehicalType(),mini.getBillID(),mini.getRatePerKiloMeter(),
                mini.getFuelType(),mini.getSeatingCapacity());
            mini.calculateBill();
            return mini;
        }
        public static MaxiVehicle getInitializeObjMaxi(String name)
        {
            MaxiVehicle max = new MaxiVehicle('D',"Tata","Car",200,1500);
            max.validateFuelType();
            max.calculateRatePerKiloMeter();
            max.calculateRatePerKG();
            Console.WriteLine("Vehicle Type: {0}\n" +
                "Bill ID: {1}\n" +
                "Rate Per Kilometer : {2}\n" +
                "Fuel Type : {3}\n" +
                "Load In Kg: {4}\n" +
                "Rate per Kg: {5}\n", max.getVehicalType(), max.getBillID(),
                max.getRatePerKiloMeter(), max.getFuelType(), max.getLoadInKg(),
                max.getRatePerKg());
            max.calculateBill();
            return max;
        }
        static void Main(string[] args)
        {
            getInitializeObjMini("");
            getInitializeObjMaxi("");
        }
    }
}
