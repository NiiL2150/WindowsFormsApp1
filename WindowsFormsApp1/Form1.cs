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
        bool formsOpened = true;
        double totalIncome = 0;
        Timer timer = new Timer();
        Dictionary<string, double> oilTypes = new Dictionary<string, double>()
        {
            {"Дизель", 0.60 },
            {"АИ-92", 0.90 },
            {"АИ-95", 1.50 },
            {"АИ-98", 1.60 }
        };
        Dictionary<int, double> foodTypes = new Dictionary<int, double>()
        {
            {0, 4.00},
            {1, 5.40},
            {2, 7.20},
            {3, 4.40}
        };

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 10000;
            foreach (var item in oilTypes.Keys)
            {
                comboBoxOilType.Items.Add(item);
            }
            comboBoxOilType.SelectedIndex = 0;
            textBoxHotDogPrice.Text = foodTypes[0].ToString();
            textBoxHamburgerPrice.Text = foodTypes[1].ToString();
            textBoxFrenchFriesPrice.Text = foodTypes[2].ToString();
            textBoxCocaColaPrice.Text = foodTypes[3].ToString();
            timer.Tick += new EventHandler(NextCustomer);
        }

        public void NextCustomer(Object myObject, EventArgs myEventArgs)
        {
            if (MessageBox.Show("Переключиться на следующего покупателя?", "Переключение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetForm();
            }
            else
            {
                timer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formsOpened == true)
            {
                MessageBox.Show($"{totalIncome:F2}$", "Total daily income", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void OilUpdate()
        {
            textBoxOilPrice.Text = oilTypes[comboBoxOilType.SelectedItem.ToString()].ToString();
            if (radioButtonGasAmount.Checked)
            {
                textBoxGasAmount.Enabled = true;
                textBoxGasMoney.Enabled = false;
                labelCurrency3.Text = "$";
                try
                {
                    labelPrice1.Text = (Double.Parse(textBoxOilPrice.Text) * Double.Parse(textBoxGasAmount.Text)).ToString("F2");
                }
                catch (Exception)
                {
                    labelPrice1.Text = "0,00";
                }
            }
            else
            {
                textBoxGasAmount.Enabled = false;
                textBoxGasMoney.Enabled = true;
                labelCurrency3.Text = "Л";
                try
                {
                    labelPrice1.Text = (Double.Parse(textBoxGasMoney.Text) / Double.Parse(textBoxOilPrice.Text)).ToString("F2");
                }
                catch (Exception)
                {
                    labelPrice1.Text = "0,00";
                }
            }
        }

        public double ReturnPrice(string price, string amount)
        {
            try
            {
                return Double.Parse(price) * Double.Parse(amount);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        void CafeUpdate()
        {
            double cafePrice = 0;
            if (checkBoxHotDog.Checked)
            {
                cafePrice += ReturnPrice(textBoxHotDogPrice.Text, textBoxHotDogAmount.Text);
                textBoxHotDogAmount.Enabled = true;
            }
            else
            {
                textBoxHotDogAmount.Enabled = false;
            }
            if (checkBoxHamburger.Checked)
            {
                cafePrice += ReturnPrice(textBoxHamburgerPrice.Text, textBoxHamburgerAmount.Text);
                textBoxHamburgerAmount.Enabled = true;
            }
            else
            {
                textBoxHamburgerAmount.Enabled = false;
            }
            if (checkBoxFrenchFries.Checked)
            {
                cafePrice += ReturnPrice(textBoxFrenchFriesPrice.Text, textBoxFrenchFriesAmount.Text);
                textBoxFrenchFriesAmount.Enabled = true;
            }
            else
            {
                textBoxFrenchFriesAmount.Enabled = false;
            }
            if (checkBoxCocaCola.Checked)
            {
                cafePrice += ReturnPrice(textBoxCocaColaPrice.Text, textBoxCocaColaAmount.Text);
                textBoxCocaColaAmount.Enabled = true;
            }
            else
            {
                textBoxCocaColaAmount.Enabled = false;
            }
            labelPrice2.Text = cafePrice.ToString("F2");
        }

        private void radioButtonGasAmount_CheckedChanged(object sender, EventArgs e)
        {
            OilUpdate();
        }

        private void comboBoxOilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            OilUpdate();
        }

        private void textBoxGasAmount_TextChanged(object sender, EventArgs e)
        {
            OilUpdate();
        }

        private void textBoxGasMoney_TextChanged(object sender, EventArgs e)
        {
            OilUpdate();
        }

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void checkBoxFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void textBoxHotDogAmount_TextChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void textBoxHamburgerAmount_TextChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void textBoxFrenchFriesAmount_TextChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void textBoxCocaColaAmount_TextChanged(object sender, EventArgs e)
        {
            CafeUpdate();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            double totalPrice;
            if (radioButtonGasAmount.Checked)
            {
                totalPrice = Double.Parse(labelPrice1.Text) + Double.Parse(labelPrice2.Text);
            }
            else
            {
                totalPrice = Double.Parse(textBoxGasMoney.Text) + Double.Parse(labelPrice2.Text);
            }
            labelPrice3.Text = totalPrice.ToString("F2");
            totalIncome += totalPrice;
            labelPrice4.Text = totalIncome.ToString("F2");
            textBoxHotDogAmount.Enabled = false;
            textBoxHamburgerAmount.Enabled = false;
            textBoxFrenchFriesAmount.Enabled = false;
            textBoxCocaColaAmount.Enabled = false;
            checkBoxHotDog.Enabled = false;
            checkBoxHamburger.Enabled = false;
            checkBoxFrenchFries.Enabled = false;
            checkBoxCocaCola.Enabled = false;
            textBoxGasAmount.Enabled = false;
            textBoxGasMoney.Enabled = false;
            comboBoxOilType.Enabled = false;
            buttonTotal.Enabled = false;
            timer.Start();
        }

        private void ResetForm()
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.labelPrice4.Text = totalIncome.ToString("F2");
            timer.Stop();
            form1.totalIncome = totalIncome;
            form1.formsOpened = true;
            formsOpened = false;
            form1.Show();
        }
    }
}
