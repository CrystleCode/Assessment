using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {

        int[] hours = new int[24] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomizeData();
        }
        private void RandomizeData()
        {
            Random randy = new Random();
            for (int i = 0; i < hours.Length; i++)
            {
                int y;
                y = randy.Next(10, 100);
                hours[i] = y;
            }
        }


        private void btnHourData_Click(object sender, EventArgs e)
        {
            int i = 200;
            try
            {
                i = Int32.Parse(txtSearchHourData.Text);
                lbxHourData.Items.Add("Hour " + i.ToString() + ": " + hours[i].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid integer input. Please input a valid integer.");
            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            int inputHour = 0;
            int inputData = 0;


            try
            {
                inputHour = Int32.Parse(txtInputHourData.Text);
                inputData = Int32.Parse(txtEditData.Text);
                hours[inputHour] = inputData;
                MessageBox.Show("Hour " + inputHour.ToString() + " now shows " + inputData.ToString() + ".");               
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid integer input. Please input a valid integer.");
            }

            

        }

        private void printAllData()
        {
            lbxHourData.Items.Clear();
            for (int i = 0; i < hours.Length; i++)
            {
                lbxHourData.Items.Add("Hour " + i + ": " + hours[i]);
            }
        }

        private void btnPrintAllData_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hours.Length; i++)
            {
                lbxHourData.Items.Add("Hour " + i + ": " + hours[i]);
            }
        }

        private void btnClearAllData_Click(object sender, EventArgs e)
        {
            lbxHourData.Items.Clear();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int arrayLen = hours.Length;

            for (int i = 0; i < arrayLen - 2; i++)
            {
                for (int j = 0; j < arrayLen - 2; j++)
                {
                    if (hours[j] > hours[j + 1])
                    {
                        int temp = hours[j];
                        hours[j] = hours[j + 1];
                        hours[j + 1] = temp;
                    }

                }
            }
            printAllData();

        }

        private void btnInsertRandomData_Click(object sender, EventArgs e)
        {
            RandomizeData();
        }
    }
}
