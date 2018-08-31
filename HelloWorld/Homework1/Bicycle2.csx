
using System;

namespace HelloWorld.Homework1
    public class Bicycle2

    {
        private string _seat;
        private int _sprocket = 20;
        public virtual int Sprocket 
           {
                return _sprocket;
            }
        
        public string Seat{
            set{
                this._seat = value;
            } 
            get{
                return _seat;
            }
        }
        public Bicycle2()
        {
                Console.WriteLine("Bicycle Default");

        }
        public Bicycle2(string type)
        {
                Console.WriteLine("Bicycle with parameter");
        }
        public string Wheels{set; get;}

        public string HandleBars{set; get;}
    } 

