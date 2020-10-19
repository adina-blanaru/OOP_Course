using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    public class Curs
    {
        //access modifiers: private, public, protected
        protected int Courseid { get; set; }
        protected string Name { get; set; }
        protected int Duration { get; set; }


        //override
        public virtual void SetCurs()
        {
            Console.WriteLine("This is the base method.");
        }

        protected void SetCurs(int id, string nume)
        {
            Courseid = id;
            Name = nume;
        }

        //overload
        protected void SetCurs(int duration)
        {
            Duration = duration;
        }


        //---------------------------------------------------------


        // the constructor doesn't necesarily need to set all the object properties
        //public Curs(int courseId, string name, int duration)
        //{
        //    Courseid = courseId;
        //    Name = name;
        //    Duration = duration;
        //}

        //public Curs(int courseId, string name)
        //{
        //    Courseid = courseId;
        //    Name = name;
        //}

        //public Curs(string name, int duration)
        //{
        //    Name = name;
        //    Duration = duration;
        //}
        //---------------------------------------------------------


        //public void SetCourseId(int courseId)
        //{
        //    //this.courseId = courseId; //using the same name as the object variable
        //    _courseId = courseId;
        //}

        //public int GetCourseId()
        //{
        //    return _courseId;
        //}


        ////class Constructor always has the same name as the class
        //public Curs()
        //{
        //    Console.WriteLine("I'm a constructor");
        //}

        ////class Constructor always has the same name as the class, preceded by ~
        //~Curs()
        //{
        //    Console.WriteLine("I'm a destructor");
        //}


        //public void SetCourse(int idCurs, string numeCurs, int durataCurs)
        //{
        //    courseId = idCurs;
        //    nume = numeCurs;
        //    durata = durataCurs;
        //}

        //public string GetCourseName()
        //{
        //    return nume;
        //}
    }
}
