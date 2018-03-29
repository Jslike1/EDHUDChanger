using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDHUDChanger.Class;
using System.Configuration;

namespace EDHUDChanger
{
    public partial class EDHUDChanger : Form
    {
        public EDHUDChanger()
        {
            InitializeComponent();
            appSettingFilepath = System.Configuration.ConfigurationManager.AppSettings["EDDirectory"];
            label2.Text = currentFilepath + appSettingFilepath;
        }

        public string set = "";

        public string currentFilepath = "Current Filepath: ";
        public string appSettingFilepath = "";


        private void button1_Click(object sender, EventArgs e)
        { 
            ChangeHUD();
        }




        public void ChangeHUD()
        {
            FileReaderWriter rw = new FileReaderWriter();
            Colour colour = new Colour(set);

            rw.ChangeHUDColour(colour);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();

            string filepath = openFileDialog.FileName;

            UpdateAppSettings(filepath);

            label2.Text = currentFilepath + appSettingFilepath;


        }


        private void UpdateAppSettings(string filepath)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.AppSettings.Settings["EDDirectory"].Value = filepath;

            configuration.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            appSettingFilepath = System.Configuration.ConfigurationManager.AppSettings["EDDirectory"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            set = "Default";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            set = "LemonChiffonDarkOrange";
            pictureBox1.ImageLocation = "http://i.imgur.com/tBEBEGX.jpg";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            set = "CyanDeepSkyBlueKhakiGold";
            pictureBox1.ImageLocation = "http://i.imgur.com/5p1Tbjl.jpg";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            set = "IvorySkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/0aakHNg.jpg";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            set = "LightCyanDodgerBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/XRUCBzY.png";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            set = "CornSilkDeepSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/XKr8eqU.png";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            set = "SalmonMediumSpringGreen";
            pictureBox1.ImageLocation = "http://i.imgur.com/ypZ7IBD.jpg";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            set = "IndianRedDodgerBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/RJGXK4Y.png";

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            set = "RedSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/aVxV54T.png";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            set = "RedDeepSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/Lr6p9bh.png";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            set = "RedSkyBlueHudson";
            pictureBox1.ImageLocation = "http://i.imgur.com/6oj3vpE.jpg";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            set = "OrangePowderBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/FwF24aa.jpg";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            set = "SandyBrownCornFlowerBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/Ovq01Qq.jpg";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            set = "SandyBrownDodgerBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/xilCiyM.png";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            set = "DarkGoldenrodTurquoise";
            pictureBox1.ImageLocation = "http://i.imgur.com/fwWiOMA.png";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            set = "GoldLightSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/7WRePgk.jpg";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            set = "YellowDeepSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/t3iUsFd.jpg";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            set = "DarkKhakiDodgerBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/fDHYcmn.png";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            set = "LawnGreenLimeOrange";
            pictureBox1.ImageLocation = "http://i.imgur.com/aChp05Y.jpg";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            set = "LawnGreenWhitePaleGreen";
            pictureBox1.ImageLocation = "http://i.imgur.com/VuMD3m8.jpg";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            set = "ForestGreenDeepSkyBlue";
            pictureBox1.ImageLocation = "http://i.imgur.com/vnBOav4.jpg";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            set = "SpringGreenPeachPuff";
            pictureBox1.ImageLocation = "http://i.imgur.com/7vSsIWs.png";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            set = "TurquoiseDeepSkyBlueKhakiGold";
            pictureBox1.ImageLocation = "http://i.imgur.com/GV1h7PS.jpg";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            set = "DeepSkyBlueBurleyWood";
            pictureBox1.ImageLocation = "http://i.imgur.com/lGbbcRk.png";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            set = "DeepSkyBlueLightSalmon";
            pictureBox1.ImageLocation = "http://i.imgur.com/rvFhAxt.jpg";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            set = "DarkDeepSkyBlueGold";
            pictureBox1.ImageLocation = "http://i.imgur.com/JyXMa0k.jpg";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            set = "DeepSkyDodgerBlueDarkOrange";
            pictureBox1.ImageLocation = "http://i.imgur.com/3dPcJ8V.jpg";
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            set = "DodgerBlueBisque";
            pictureBox1.ImageLocation = "http://i.imgur.com/MWueUzj.jpg";
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            set = "DodgerBlueLightSalmon";
            pictureBox1.ImageLocation = "http://i.imgur.com/07BjGpc.png";
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            set = "CornFlowerBluePapayaWhip";
            pictureBox1.ImageLocation = "http://i.imgur.com/nKld9Gs.png";
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            set = "CornFlowerBlueOrange";
            pictureBox1.ImageLocation = "http://i.imgur.com/llF5BSe.png";
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            set = "LightBlueRed";
            pictureBox1.ImageLocation = "http://i.imgur.com/SvgA3jW.jpg";
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            set = "BlueVioletPaleGreen";
            pictureBox1.ImageLocation = "http://i.imgur.com/TV5PYz8.jpg";
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            set = "BlueMediumStateBlueRed";
            pictureBox1.ImageLocation = "http://i.imgur.com/gKXimWl.jpg";
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            set = "MediumPurpleMagenta";
            pictureBox1.ImageLocation = "http://i.imgur.com/BA7zy2J.jpg";
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            set = "MediumPurpleSandyBrown";
            pictureBox1.ImageLocation = "http://i.imgur.com/PVgROtj.jpg";
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            set = "MediumPurpleWheat";
            pictureBox1.ImageLocation = "http://i.imgur.com/7v2i9ON.png";
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            set = "PlumTurquoise";
            pictureBox1.ImageLocation = "http://i.imgur.com/aZFHynC.jpg";
        }
    }
}
