using System;
public class Vehicle 
{
//Reference type field
// Private variables should use an underscore
    private string _color;

//Normal Property
    public string Color 
    {
        get {
            return _color;
        }
        set {
            Console.WriteLine(value);
            this._color = value;
        }
    }

    //Automatic Property
    public string Wheeltype { get; set;}
    //Default Constructor
    public Vehicle()  
    {  
        Console.WriteLine("Default Constructor");
    }

    public Vehicle(string type) // Constructor with a parameter
    {
        Console.WriteLine(type);
    }
    public void OpenDoor()   //Method with no parameters
    {
        Console.WriteLine("Door is Open");
    }
    public virtual void CloseWindow() // Example of Polymorphisms
    {
        Console.WriteLine("Vehicle Window Closed");
    }
}