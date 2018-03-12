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
            set = "Default";
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
    }
}
