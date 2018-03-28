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


        public string connectionString = System.Configuration.ConfigurationManager.AppSettings["EDDirectory"];

        public int counter = 1;

        public void ChangeHUDColour(Colour colour)
        {

            try
            {

                string[] arrLine = File.ReadAllLines(connectionString);

                arrLine[49] = $"			<MatrixRed>	{colour.Red} </MatrixRed>";
                arrLine[50] = $"			<MatrixGreen>	{colour.Green} </MatrixGreen>";
                arrLine[51] = $"			<MatrixBlue>	{colour.Blue} </MatrixBlue>";

                File.WriteAllLines(connectionString, arrLine);
                MessageBox.Show("Successfully wrote file.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);


            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }






    }
}
