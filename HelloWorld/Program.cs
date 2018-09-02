using System;
using HelloWorld.Homework1RO;

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
       /* 
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
        Console.WriteLine(myTricycle.Sprocket);
        */
        /* 
            Bicycle2 myBike = new Bicycle2("BMX");
            MountainBike myMountain = new MountainBike();

            DownHillBike myDownhillBike = new DownHillBike();

            Console.WriteLine(myBike.Seat);
            Console.WriteLine(myBike.Sprocket);
            Console.WriteLine(myBike.WheelSpokes);
            Console.WriteLine(myMountain.WheelSpokes);

            Console.WriteLine(myDownhillBike.WheelSpokes);
            myBike.Pedal("Pedaling myBike");
            myBike.Brake();

            myMountain.MyMountainColor();
            myMountain.Pedal("Pedaling myMountain");
            myMountain.Brake();
            myDownhillBike.MyMountainColor();
            myDownhillBike.Pedal("Pedaling myDownhillBike");
            myDownhillBike.Brake();  */
            HelloWorld.Week2.NumericTypes myNumericType = 
            new HelloWorld.Week2.NumericTypes();
            HelloWorld.Week2.ReferenceTypes myReferenceType =
            new HelloWorld.Week2.ReferenceTypes();
            HelloWorld.Week2.Statements myStatements = 
            new HelloWorld.Week2.Statements();
            HelloWorld.Week2.ValueTypesContinues myVTC = 
            new HelloWorld.Week2.ValueTypesContinues();
            HelloWorld.Testme.School mySchool = 
            new HelloWorld.Testme.School();
            HelloWorld.Testme.NaturalNumbers myNaturalNumbers =
            new HelloWorld.Testme.NaturalNumbers();
            myNumericType.BasicMath();
            myNumericType.CheckOperator();
            myNumericType.ComparisonOperatorsNumeric();
            myNumericType.ConvertFloatToInt();
            myNumericType.EnumSample();
           // myNumericType.RefSample(5);
            myNumericType.GetHashCode();
            myNumericType.getSomeTypes();
            myNumericType.GetType();
            myNumericType.IncrementDecrement();
            myNumericType.LongFromInt();
           // myNumericType.OutSample("Joe HayDen Smith", ,)
            myReferenceType.ArrayJaggedSample();
            myReferenceType.ArrayRectanglurSample();
            myReferenceType.ArraySingleSample();
            myReferenceType.CharType();
            myReferenceType.CompareStrings();
      //      myReferenceType.Equals();
            myReferenceType.GetHashCode();
            myReferenceType.GetType();
            myReferenceType.JoiningStrings();
            myReferenceType.JoinStringsWithBuilder();
            myReferenceType.PlaceHolderString();
            myReferenceType.ToString();
            int x,y,numlimit;
            x = 10;
            y = 15;
            numlimit = 10;
            string d;
            d = "Sunday";

            myStatements.ExpressionStatementExample(x,y);
            myStatements.ForEachLoopExample();
            myStatements.GetHashCode();
            myStatements.IfStatementBasicExample(x,y);
            myStatements.IfStatementChainExample(d);
            myStatements.JumpStatementExample(d);
            myStatements.SwitchStatemntExample(d);
            myStatements.WhileLoopExample();
            myStatements.DoWhileLoopExample();

            mySchool.DisplayGradeWord("E");
            mySchool.DisplayGradeWord("V");
            mySchool.DisplayGradeWord("G");
            mySchool.DisplayGradeWord("A");
            mySchool.DisplayGradeWord("F");

            myNaturalNumbers.CountMe(numlimit);
        }
    }
}
