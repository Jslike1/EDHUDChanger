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

                case "CornSilkDeepSkyBlue":
                    Red = "1, 0.64, 0.46";
                    Green = "0.21, 0.79, 0.41";
                    Blue = "-0.22, -0.1, 0.34";
                    break;

                case "SalmonMediumSpringGreen":
                    Red = "1, 0, 0.07";
                    Green = "0, 1, 1";
                    Blue = "0, 1, 0";
                    break;

                case "IndianRedDodgerBlue":
                    Red = "1.5, -0.1, -0.1";
                    Green = "0, 2, 2";
                    Blue = "-0.5, -0.5, 0.5";
                    break;

                case "RedSkyBlue":
                    Red = "0.5, -0.5, -2";
                    Green = "0, 2, 2";
                    Blue = "0, 0, 2";
                    break;

                case "RedDeepSkyBlue":
                    Red = "1, 0, 0";
                    Green = "0, 0.3, 0";
                    Blue = "0, 0.6, 1";
                    break;

                case "RedSkyBlueHudson":
                    Red = "2, 0, 0";
                    Green = "0, .30, 0";
                    Blue = "0, 1.1, 2";
                    break;

                case "OrangePowderBlue":
                    Red = "0, 0.25, 1";
                    Green = "0, 1, 0";
                    Blue = "1, 0, 0";
                    break;

                case "SandyBrownCornFlowerBlue":
                    Red = "0.7, 0.08, -0.08";
                    Green = "0, 1, 1";
                    Blue = "0.15, -0.15, 1";
                    break;

                case "SandyBrownDodgerBlue":
                    Red = "1, 0.15, 0 ";
                    Green = "0, 1, 0.85";
                    Blue = "0, 0, 1";
                    break;

                case "DarkGoldenrodTurquoise":
                    Red = "0.5, 0, -0.5";
                    Green = "-0.95, 1, -0.75";
                    Blue = "0.17, 0.31, 1";
                    break;
            }
        }

    }
}
