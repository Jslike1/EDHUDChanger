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

                case "GoldLightSkyBlue":
                    Red = "1, 0.27, 0";
                    Green = "0, 0.53, 0";
                    Blue = "0, 0.53, 1";
                    break;

                case "YellowDeepSkyBlue":
                    Red = "1, 0.41, 0";
                    Green = "0, 1, 0";
                    Blue = "0, 0, 1";
                    break;

                case "DarkKhakiDodgerBlue":
                    Red = "0.45, 0.3, 0";
                    Green = "0, 1, 0.85";
                    Blue = "0, 0, 1";
                    break;

                case "LawnGreenLimeOrange":
                    Red = "0, 1, 0";
                    Green = "1, 0, -1";
                    Blue = "0, 0, -1";
                    break;

                case "LawnGreenWhitePaleGreen":
                    Red = "0, 1, 0";
                    Green = "1, 1, 0";
                    Blue = "0, 0, 1";
                    break;

                case "ForestGreenDeepSkyBlue":
                    Red = "0.2, 0, 0";
                    Green = "-2, 1, 0";
                    Blue = "0, 0, 1";
                    break;

                case "SpringGreenPeachPuff":
                    Red = "0, 0.3, 0";
                    Green = "0, 1, 0.85";
                    Blue = "1, 0, 0";
                    break;

                case "TurquoiseDeepSkyBlueKhakiGold":
                    Red = "0.05, 0.25, 0.6";
                    Green = "0, 1, 0";
                    Blue = "1, 0, 0";
                    break;

                case "DeepSkyBlueBurleyWood":
                    Red = "0.00, 0.40, 0.90";
                    Green = "0.00, 0.61, 0.00";
                    Blue = "0.95, 0.00, 0.00";
                    break;

                case "DeepSkyBlueLightSalmon":
                    Red = "0, 0.5, 1";
                    Green = "0, 0.5, 0";
                    Blue = "1, 0, 0";
                    break;

                case "DarkDeepSkyBlueGold":
                    Red = "0.1, 0, 0";
                    Green = "-1, 1, 2";
                    Blue = "2, 0, -1";
                    break;

                case "DeepSkyDodgerBlueDarkOrange":
                    Red = "-0.17, 0.23, 1";
                    Green = "0, 1, 0";
                    Blue = "1, -0.27, -0.53";
                    break;

                case "DodgerBlueBisque":
                    Red = "0, 0.15, 1";
                    Green = "0, 1, 0.87";
                    Blue = "1, 0.46, 0.24";
                    break;

                case "DodgerBlueLightSalmon":
                    Red = "0, 0.15, 1";
                    Green = "0, 1, 0.85";
                    Blue = "1, 0, 0 ";
                    break;

                case "CornFlowerBluePapayaWhip":
                    Red = "0.15, 0.25, 0.9";
                    Green = "0.62, 1, 0.32";
                    Blue = "0.48, 0, 0";
                    break;

                case "CornFlowerBlueOrange":
                    Red = "0.25, 0.43, 1";
                    Green = "0.83, 1, 0";
                    Blue = "1, 0, 0";
                    break;

                case "LightBlueRed":
                    Red = "0.35, 0.5, 1.75";
                    Green = "-0.5, 2, -1.25";
                    Blue = "1.75, -1, -0.4";
                    break;

                case "BlueMediumStateBlueRed":
                    Red = "0.2, 0.05, 2";
                    Green = "-0.15, 2, -0.5";
                    Blue = "1.75, -1, -0.3";
                    break;

                case "BlueVioletPaleGreen":
                    Red = "0, 0, 1";
                    Green = "1, 0, 0";
                    Blue = "0, 1, 0";
                    break;

                case "MediumPurpleMagenta":
                    Red = "0.3, 0.05, 1.2";
                    Green = "-0.15, 2, -0.5";
                    Blue = "1, -1.3, 0.7";
                    break;

                case "MediumPurpleSandyBrown":
                    Red = "0.3, 0, 1";
                    Green = "0.25, 1, 0.25";
                    Blue = "1, 0, 0";
                    break;

                case "MediumPurpleWheat":
                    Red = "0.3, 0, 1";
                    Green = "0.3, 1, 0.3";
                    Blue = "1, 0.5, 0.5";
                    break;

                case "PlumTurquoise":
                    Red = "0.4, 0.1, 0.5";
                    Green = "0, 1, 0";
                    Blue = "-0.25, 0.15, 0.7";
                    break;

            }
        }

    }
}
