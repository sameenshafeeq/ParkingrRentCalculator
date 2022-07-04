using System;

namespace CarPaarkingBill
{
    class Program
    {
        static void Main(string[] args)
        {
            parkingGarage parkingGarage=new parkingGarage("Al rehmet Parking Garage");
            Bikes b1 = new Bikes();
            Bikes b2 = new Bikes();
            Bikes b3 = new Bikes();

            Cars car1 = new Cars();
            Cars car2 = new Cars();
            Cars car3 = new Cars();

            Buses bus1 = new Buses();
            Buses bus2 = new Buses();
            Buses bus3 = new Buses();


            double rent =b1.calculateRent(5);
            double rent2 =b2.calculateRent(1);
            double rent3 = b3.calculateRent(24);

            double rent4 = car1.calculateRent(5);
            double rent5 = car2.calculateRent(1);
            double rent6 = car3.calculateRent(24);

            double rent7 = bus1.calculateRent(5);
            double rent8 = bus2.calculateRent(1);
            double rent9 = bus3.calculateRent(24);

            Console.WriteLine("Rent for Bike parked for 5 hours:"+rent);
            Console.WriteLine("Rent for Bike parked for 1 hour:"+rent2);
            Console.WriteLine("Rent for Bike parked for 24 hours "+rent3);

            Console.WriteLine("Rent for Car  parked for 5 hours:" + rent4);
            Console.WriteLine("Rent for Car  parked for 1 hour:" + rent5);
            Console.WriteLine("Rent for Car parked for 24 hours " + rent6);

            Console.WriteLine("Rent for Bus  parked for 5 hours:" + rent7);
            Console.WriteLine("Rent for Bus  parked for 1 hour:" + rent8);
            Console.WriteLine("Rent for Bus  parked for 24 hours " + rent9);
        }
    }
}
