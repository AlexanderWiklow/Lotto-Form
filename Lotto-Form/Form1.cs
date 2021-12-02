using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbNew_Click(object sender, EventArgs e)
        {

            //C# has a random class, which you can start with. Your requirement that each number is allowed only once requires some work, as this is no longer random. What you can do, is have an array for 8 numbers and the repeatedly call the next random number an check if it’s already in the filled part of your array. When you have filled all 8 slots of your array, you can stop filling it and print it out.

            //instansiera random 
            Random rnd = new Random();

            int[] talArray = new int[7];

            for (int i = 0; i < talArray.Length; i++)
            {
                int slumpTal = rnd.Next(0, 38);

                for (int j = 0; j < talArray.Length; j++)
                {
                    if (talArray[j] == slumpTal )
                    {
                        slumpTal = rnd.Next(0, 38);
                    }
                }
                
                talArray[i] = slumpTal;
            }

            //Skriv ut till boxarna 
            txtFirst.Text = Convert.ToString(talArray[0]);
            txtSecond.Text = Convert.ToString(talArray[1]);
            txtThird.Text = Convert.ToString(talArray[2]);
            txtFourth.Text = Convert.ToString(talArray[3]);
            txtFifth.Text = Convert.ToString(talArray[4]);
            txtSixth.Text = Convert.ToString(talArray[5]);
            txtSeventh.Text = Convert.ToString(talArray[6]);

        }
    }
}
