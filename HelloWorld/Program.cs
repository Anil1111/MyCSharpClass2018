using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
        {
            /* 
        Console.WriteLine("Hello World!");
        Vehicle vehicle = new Vehicle("Chevy");

        Console.WriteLine( "Using Get " + vehicle.Color);
        vehicle.Color = "Blue";
        Console.WriteLine( "Using Get " + vehicle.Color);
      
        vehicle.Wheeltype = "Chrome";

        Console.WriteLine(vehicle.Wheeltype);

        //myVehicle is a copy of the Vehicle Class
        Vehicle myVehicle = new Vehicle();
        myVehicle.Color = "Red";
        myVehicle.OpenDoor();
        myVehicle.CloseWindow();

        Car myCar = new Car();
        myCar.Color = "Green";
        myCar.CloseWindow(); */
       
        Bicycle bicycle = new Bicycle("Schwinn");

        Console.WriteLine( "Using Get " + bicycle.Color);
        bicycle.Color = "Polka Dot";
        Console.WriteLine( "Using Get " + bicycle.Color);
      
        bicycle.Wheeltype = "Nobby";

        Console.WriteLine(bicycle.Wheeltype);

        //myBicycle is a copy of the Bicycle Class
        Bicycle myBicycle = new Bicycle();
        myBicycle.Color = "Red";
        myBicycle.Pedal();
        myBicycle.Brake();

        Tricycle myTricycle = new Tricycle();
        myTricycle.Color = "Green";
        myTricycle.Brake();  
        }
    }
}
