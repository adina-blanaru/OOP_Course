using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePage myHomePage = new HomePage();
            //myHomePage.MetodaMea(23, "test");
            myHomePage.SetCurs();

            //Tutorial myTutorial = new Tutorial();


            // use the class constructor
            //Curs cursTestAutomation = new Curs(1, "Testare automatizata");
            //Curs cursJavaDev = new Curs("Java development", 14);
            //---------------------------------------------------------


            //Curs cursTestAutomation = new Curs(1, "Testare automatizata", 12);
            //Curs cursJavaDev = new Curs(2, "Java development", 14);
            //---------------------------------------------------------


            //var a = cursulMeu._courseId = 123;
            //---------------------------------------------------------


            //cursulMeu.SetCourse(1, "Testare automatizata", 12);
            //Console.WriteLine($"Numele cursului este: {cursulMeu.GetCourseName()}");
            //---------------------------------------------------------



            Console.ReadLine();
        }
    }
}
