using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        //TODO: Create a matrix for all 9 boxes.
        //Distribute random starting numbers at the start of the game.
        //Make button status that changes on click
        int a;
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool i1 = false, i2 = false, i3 = false, i4 = false, i5 = false, i6 = false, i7 = false, i8 = false, i9 = false;

#pragma warning disable IDE1006 // Naming Styles
        private void b7_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i7 = true;
                t = 1;
            }
            else
            {
                i7 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i8 = true;
                t = 1;
            }
            else
            {
                i8 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i9 = true;
                t = 1;
            }
            else
            {
                i9 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i6 = true;
                t = 1;
            }
            else
            {
                i6 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i5 = true;
                t = 1;
            }
            else
            {
                i5 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i4 = true;
                t = 1;
            }
            else
            {
                i4 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i3 = true;
                t = 1;
            }
            else
            {
                i3 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i2 = true;
                t = 1;
            }
            else
            {
                i2 = false;
                t = 0;
            }
            Number_Click();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (t == 0)
            {
                i1 = true;
                t = 1;
            }
            else
            {
                i1 = false;
                t = 0;
            }
            Number_Click();
        }
#pragma warning restore IDE1006 // Naming Styles

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click()
        {
            if(i1 == true)
            {
                a = Int32.Parse(b1.Text);
            }
            if (i2 == true)
            {
                a = Int32.Parse(b2.Text);
            }
            if (i3 == true)
            {
                a = Int32.Parse(b3.Text);
            }
            if (i4 == true)
            {
                a = Int32.Parse(b4.Text);
            }
            if (i5 == true)
            {
                a = Int32.Parse(b5.Text);
            }
            if (i6 == true)
            {
                a = Int32.Parse(b6.Text);
            }
            if (i7 == true)
            {
                a = Int32.Parse(b7.Text);
            }
            if (i8 == true)
            {
                a = Int32.Parse(b8.Text);
            }
            if (i9 == true)
            {
                a = Int32.Parse(b9.Text);
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {

        }
    }
}
