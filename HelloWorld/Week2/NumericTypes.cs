using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Week2
{
    class NumericTypes
    {
        /*Integral - Signed  */
        //-128 - 127        
        private sbyte _mySbyteValue = 2;
        
        //–32,768 to 32,767
        private short _myShortValue = 4;
        
        //–2,147,483,648 to 2,147,483,647
        private int _myIntValue = 25000;        

        //–2,147,483,648 to 2,147,483,647
        private long _myLongValue = 1_234_567L;   //Underscores for more readability
        private long _myLongValue2 = 0x5F;

        /*Integral - Unsigned */
        //0 - 255
        private byte _myByteValue = 3;

        //0 to 65,535
        private ushort _myUShortValue = 35;

        //0 to 4,294,967,295
        private uint _myUInt = 2345U;

        //0 to 18,446,744,073,709,551,615
        private ulong _myULong = 123456UL;

        /*Real */

        //3.4E +/- 38 (7 digits)
        private float myFloatValue = -123.6589F;        //Used for floating-point used for scientific and graphical calculations

        //1.7E +/- 308 (15 digits)
        private double _myDoubleValue = 12.34D;     //Used for floating-point used for scientific and graphical calculations
        private double _myDoubleValue2 = 1E06;

        //-7.9228E+24 - 7.9228E+24
        private decimal _myDecimalValue = 13.234M;  //Used for Financial calculations

        // Enum declaration with default values
        private enum Positon { Left, Right, Top, Bottom };

        // Enum declaration with defined values
        private enum MovieType { Action = 100, Comedy = 200, Drama = 300};

        // Enum declaration with mixed defined and non-defined values
        private enum Days { Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat}

        //Numeric Literal Type Inference
        public void getSomeTypes()
        {
            Console.WriteLine(3.0.GetType());   // Double
            Console.WriteLine(myFloatValue.GetType()); //Float
        }
        
        //Explicit Cast where fractions are truncated and not rounded
        public void ConvertFloatToInt()
        {
            int converted = (int)myFloatValue;
            Console.WriteLine(converted);
        }

        //Implicit cast which requires no casting
        //The reverse requires a cast
        public void LongFromInt()
        {
            long someLongValue = _myIntValue;
            int someIntValue = (int)_myLongValue;

            Console.WriteLine(someLongValue);
        }

        public void IncrementDecrement()
        {
            int myVal = 1, myOtherVal = 10;
            Console.WriteLine(myVal++);
            Console.WriteLine(myOtherVal--);
            Console.WriteLine(--myVal);
            Console.WriteLine(++myOtherVal);
        }
        
        public void BasicMath()
        {
            int myVal = 5, myOtherVal = 10;

            int addVal = myVal + myOtherVal;
            int subtractVal = myOtherVal - myVal;
            int multiplyVal = myVal * myOtherVal;
            int divisionVal = myVal / myOtherVal;
            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
        }

        // Overflow Check Operators
        public void CheckOperator()
        {
            int test = 100;
            int test2 = 100;
            int testVal = checked(test * test2);
            checked
            {
                testVal = test * test2;
            }
            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.WriteLine(testVal);
        }

        public void SpecialValues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0/ -0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0/0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }

        public void ComparisonOperatorsNumeric()
        {
            /**bool values can be true or false. Not cast type for bool to numeric types */
            int x = 3, y = 5, z = 3;
            Console.WriteLine(x == y); // False
            Console.WriteLine(x != y); // true
            Console.WriteLine(x = z); // true
        }

        /**
     * Enums are a special type that allows you to specify a group of numeric constants.
     * Converting an enum requires and explicit cast.
     * **/
        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", Days.Thur);
            Console.WriteLine("Favorite type of movie value is {0}", MovieType.Action);
        }


     /**
      * To pass a Reference modifier we use the ref keyword
     * **/
        public void RefSample(ref int value)
        {
            int sample = value + 5;
            Console.WriteLine(sample);
        }
    /**
     *  The out keyword is like ref except that it doesn't need to be assigned before entering a method
     * **/
        public void OutSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
       
    }

    /**
     * Structs are simular to class files except its considered a value type rather than a reference type
     * **/
    public struct TestStruct
    {
        int testOne;
        int testTwo;
        public TestStruct(int one, int two)
        {
            this.testOne = one;
            this.testTwo = two;
        }
    }
        
}

