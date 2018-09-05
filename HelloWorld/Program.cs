using System;
using HelloWorld.Homework1RO;
using HelloWorld.Testme;
using HelloWorld.Week2;


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
            HelloWorld.Homework2.School mySchool2 = 
            new HelloWorld.Homework2.School();
            HelloWorld.Homework2.NaturalNumbers myNaturalNumbers2 =
            new HelloWorld.Homework2.NaturalNumbers();
            HelloWorld.Testme.IsPalinDrome myPalinDrome = 
            new HelloWorld.Testme.IsPalinDrome();
            myNumericType.BasicMath();
            /* 
       //     myNumericType.CheckOperator();
       //     myNumericType.ComparisonOperatorsNumeric();
            myNumericType.ConvertFloatToInt();
      //      myNumericType.EnumSample();
           // myNumericType.RefSample(5);
            myNumericType.GetHashCode();
      //      myNumericType.getSomeTypes();
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
            bool answerPalinDrome = false;

            myStatements.ExpressionStatementExample(x,y);
            myStatements.ForEachLoopExample();
            myStatements.GetHashCode();
            myStatements.IfStatementBasicExample(x,y);
            myStatements.IfStatementChainExample(d);
            Console.WriteLine(myStatements.JumpStatementExample(d));
            myStatements.SwitchStatemntExample(d);
            myStatements.WhileLoopExample();
            myStatements.DoWhileLoopExample();
            myStatements.ExpressionStatementExample(x,y);
            myStatements.ConstantExample();

            mySchool.DisplayGradeWord("E");
            mySchool.DisplayGradeWord("V");
            mySchool.DisplayGradeWord("G");
            mySchool.DisplayGradeWord("A");
            mySchool.DisplayGradeWord("F");
            mySchool.DisplayGradeWord("X");

            myNaturalNumbers.CountMe(numlimit);

            mySchool2.DisplayGradeWord("E");
            mySchool2.DisplayGradeWord("V");
            mySchool2.DisplayGradeWord("G");
            mySchool2.DisplayGradeWord("A");
            mySchool2.DisplayGradeWord("F");
            mySchool2.DisplayGradeWord("X");

            mySchool.DisplayGradeWord("e");
            mySchool.DisplayGradeWord("v");
            mySchool.DisplayGradeWord("g");
            mySchool.DisplayGradeWord("a");
            mySchool.DisplayGradeWord("f");
            mySchool.DisplayGradeWord("x");

            myNaturalNumbers2.CountMe(numlimit);
     //       myPalinDrome.IsPalindrome(d,answerPalinDrome);
     */
            AdditionalExamples ae = new AdditionalExamples();
             

        /*    Console.WriteLine(ae.UseUmbrella(true,false,true));
            Console.WriteLine(ae.UseUmbrella(true,true,true));
            Console.WriteLine(ae.UseUmbrella(false,false,false));
            Console.WriteLine(ae.UseUmbrella(false,true,false));*/
            Console.WriteLine(mySchool.DisplayGradeWord('E'));
            Console.WriteLine(mySchool.DisplayGradeWord('V'));
            Console.WriteLine(mySchool.DisplayGradeWord('G'));
            Console.WriteLine(mySchool.DisplayGradeWord('A'));
            Console.WriteLine(mySchool.DisplayGradeWord('F'));
            Console.WriteLine(mySchool.DisplayGradeWord('X'));
            Console.WriteLine(mySchool2.DisplayGradeWord('E'));
            Console.WriteLine(mySchool2.DisplayGradeWord('V'));
            Console.WriteLine(mySchool2.DisplayGradeWord('G'));
            Console.WriteLine(mySchool2.DisplayGradeWord('A'));
            Console.WriteLine(mySchool2.DisplayGradeWord('F'));
            Console.WriteLine(mySchool2.DisplayGradeWord('X'));


        }
    }
}
