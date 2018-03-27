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

                case "LemonChiffonDarkOrange":
                    this.Red = "0.39, 0.47, 0.21";
                    this.Green = "0.08, 0.14, 1";
                    this.Blue = "1, -0.03, -1";
                    break;

                case "CyanDeepSkyBlueKhakiGold":
                    this.Red = "0, 0.25, 0.75";
                    this.Green = "0, 1, 0";
                    this.Blue = "1, 0, 0";
                    break;

                case "IvorySkyBlue":
                    this.Red = "1, 1, 1";
                    this.Green = "0, 1, 0";
                    this.Blue = "0, 0, 1";
                    break;

                case "LightCyanDodgerBlue":
                    this.Red = "0.57, 0.77, 0.87";
                    this.Green = "-0.36, 0.44, -1";
                    this.Blue = "-0.2, -0.12, 1";
                    break;
            }
        }

    }
}
