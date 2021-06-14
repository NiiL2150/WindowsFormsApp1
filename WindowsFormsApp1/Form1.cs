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
        void UpdateInfo()
        {
            int x = listBox2.Items.Count * 100 / (listBox1.Items.Count + listBox2.Items.Count);
            progressBar1.Value = x;
            label1.Text = $"{x}%";
        }
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(listBox1, "Item list");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            UpdateInfo();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            UpdateInfo();
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                if (listBox2.SelectedItems.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                }
            }
            UpdateInfo();
        }
    }
}
