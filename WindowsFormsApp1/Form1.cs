using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NoButton_MouseHover(object sender, EventArgs e)
        {
            NoButton.Location = new Point(random.Next(0, 400), random.Next(0, 250));
        }

        private void NoButton_MouseClick(object sender, MouseEventArgs e)
        {
            NoButton.Location = new Point(random.Next(0, 400), random.Next(0, 250));
        }

        private void YesButton_MouseClick(object sender, MouseEventArgs e)
        {
            SalaryText.Text = "How else!";
        }
    }
}
