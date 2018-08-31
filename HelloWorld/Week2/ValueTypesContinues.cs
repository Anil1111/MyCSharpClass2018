using System;

namespace HelloWorld.Week2
{
    public class ValueTypesContinues
    {
        #region Enums

        // Enum declaration with default values
        private enum Position { Left, Right, Top, Bottom };

        // Enum declaration with defined values
        private enum MovieType { Action = 100, Comedy = 200, Drama = 300 };

        // Enum declaration with mixed defined and non-defined values
        private enum Days { Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat};

        /*
         * Enums are a special type that allows you to specify a group of numeric c
         * Converting an enum requires and explicit cast.
         *
         */

         public void EnumSample()
         {
             Console.WriteLine("Value for days not set is {0}", (int)Days.Thur);
             Console.WriteLine("Value for days not set is {0}", Days.Thur);
             Console.WriteLine("Favorite type of movie value is {0}",MovieType.Action);   
         }

         #endregion
    }
}