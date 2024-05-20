using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_exam_v2.Classes
{
    class Journey
    {
        private string locationstart;
        private string locationend;

        public Journey()
        {

        }

        public string LocationStart
        {
            get
            {
                return locationstart;
            }
            set
            {
                locationstart = value;
            }
        }

        public string LocationEnd
        {
            get
            {
                return locationend;
            }
            set
            {
                locationend = value;
            }
        }

        public void printLocationStartandEnd()
        {
            Console.WriteLine("You traveled from {0} to {1}", locationstart, locationend);
        }



    }
}
