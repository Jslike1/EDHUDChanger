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
    }
}
