using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    partial class HomePage
    {
        public void MetodaMea(int id, string name)
        {
            SetCurs(id, name);
        }
        public override void SetCurs()
        {
            base.SetCurs();
            Console.WriteLine("I'm an override method.");
        }
    }

    // abstract classes, cannot be instantiated, should not have properties and methods
    // used for common elements for all pages (eg. page header)
    public abstract class LandingPage
    { 
    
    }


    //interface behaves as a normal class, they can be instantiated, can be inherited, can be extended
    interface ILandingPage
    {
        void SetCourse();
    }

    //class implements the interface
    //a class can implement multiple interfaces
    //much slower than abstract classes
    public class MyClass : ILandingPage
    {
        public void SetCourse()
        { 
        
        }
    }
}
