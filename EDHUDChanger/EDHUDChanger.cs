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

namespace EDHUDChanger
{
    public partial class EDHUDChanger : Form
    {
        public EDHUDChanger()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FileReaderWriter rw = new FileReaderWriter();

            rw.ChangeHUDColor();
        }
    }
}
