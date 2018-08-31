
using System;

namespace HelloWorld.Homework1
{
public class MountainBike : Bicycle2
 {
     private int _sprocket = 30;
     public override int Sprocket
     {
         get {
             return _sprocket
         }
     }
    
    public MoubtainBike()
    {
        Console.Write("Mountain Bike");
    }
 }
}