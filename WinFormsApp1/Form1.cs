using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void State() {

            Etext.Text = textBox1.Text;
            if (Etext.IsModified())
            {
                Etext.Original.Text = Etext.Text;
            }
        }

        Class1 Etext = new Class1
        {

            Text = "",
            Original = new Class1Clone
            {
                Text = "",
            }
        };


        private void button1_Click(object sender, EventArgs e)
        {
            Etext.Text = Etext.Text;
            if (Etext.IsModified())
            {
                Etext.Original.Text = Etext.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etext.Revert();
            DisplayDetalis();
        }

        private void DisplayDetalis()
        {
            textBox1.Text = Etext.Text;
        }

        private void buttonIsModified_Click(object sender, EventArgs e)
        {
            Etext.Text = textBox1.Text;
            if (Etext.IsModified())
            {
                MessageBox.Show("Values modified");
            }
            else
            {
                MessageBox.Show("Values not modified");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDetalis();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            State();
            MessageBox.Show("Is modified");
        }
    }
}