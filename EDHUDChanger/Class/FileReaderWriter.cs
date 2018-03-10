using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EDHUDChanger.Class
{
    public class FileReaderWriter
    {


        //public string connectionString = @"C:\Program Files (x86)\Steam\steamapps\common\Elite Dangerous\Products\elite-dangerous-64\GraphicsConfiguration.xml";

        public string connectionString = System.Configuration.ConfigurationManager.AppSettings["EDDirectory"];

        //System.Configuration.ConfigurationManager.ConnectionStrings["EDDirectory"].ConnectionString;



        public int counter = 1;

        //@"C:\Program Files (x86)\Steam\steamapps\common\Elite Dangerous\Products\elite-dangerous-64.GraphicsConfiguration.XML";

        public void ChangeHUDColor()
        {

            try
            {

                string[] arrLine = File.ReadAllLines(connectionString);

                arrLine[49] = "			<MatrixRed>		0, 0, 1 </MatrixRed>";
                arrLine[50] = "			<MatrixGreen>	0, 1, 0 </MatrixGreen>";
                arrLine[51] = "			<MatrixBlue>	1, 0, 0 </MatrixBlue>";

                File.WriteAllLines(connectionString, arrLine);
           
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }






    }
}
