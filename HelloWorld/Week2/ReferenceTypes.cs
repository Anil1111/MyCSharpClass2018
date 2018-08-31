using System;
using System.text;

namespace HelloWorld.Week2
{
    public class ReferenceTypes
    {
        private string _testString = "Test String";
        private string _testString2 = "is awesome";

        #region Joining Strings

        public void JoiningStrings()
        {
           string secondTest = "written test";
           Console.WriteLine("This is a " + _testString); // This is a Test String
           Console.WriteLine(_testString + secondTest); //TestStringwritten test

        }

        public void JoinStringsWithBuilder()
        {
            StringBuilder builder = new Stringbuilder();
            builder.Append(_testString)
            .Append(_testString2)
            .Append(" and super cool");

            //In order to use the builder, you ahve to calll the ToString method so it converts.
            Console.WriteLine(builder.ToString());
        }
        #endregion

        #region Placeholders and compare strings
        public void PlaceHolderString()
        {
           string sampleFour = "forth";
           //This is a third Test String
           Console.WriteLine("This is a third {0}", _testString);
           Console.WriteLine("This {0} is {2} the {1}", _testString, sampleFour,35);
        }

        public void CompareStrings()
        {
           string ab = "Test String";
           Console.WriteLine(_testString = ab);
        }

        #endregion

        #region Char

    }
}
