using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class Tutorial:Curs //Tutorial class inherits the Curs class
    {
        public void RenameTutorial(int tutorialId, string tutorialName)
        {
            SetCurs(tutorialId, tutorialName);

            //Courseid = tutorialId;
            //Name = tutorialName;
        }

    }
}
