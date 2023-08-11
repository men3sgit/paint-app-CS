using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);

      

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelloBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonName = clickedButton.Name;
                MessageBox.Show("Button name: " + buttonName, "Button Clicked");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            boardPanel.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }


        private void pencilBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
