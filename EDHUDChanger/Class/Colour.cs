using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDHUDChanger.Class
{
    public class Colour
    {
        public string Red { get; set; }
        public string Green { get; set; }
        public string Blue { get; set; }

        public Colour(string set)
        {

            switch (set)
            {
                case "Default":

                    this.Red = "1, 0, 0";
                    this.Green = "0, 1, 0";
                    this.Blue = "0, 0, 1";
                    break;


            }
        }

    }
}
