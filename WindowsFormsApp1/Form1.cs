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
        Timer customerTimer = new Timer(), timeTimer = new Timer();
        string local = "RU";
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
            customerTimer.Interval = 10000;
            timeTimer.Interval = 100;
            foreach (var item in oilTypes.Keys)
            {
                comboBoxOilType.Items.Add(item);
            }
            comboBoxOilType.SelectedIndex = 0;
            textBoxHotDogPrice.Text = foodTypes[0].ToString();
            textBoxHamburgerPrice.Text = foodTypes[1].ToString();
            textBoxFrenchFriesPrice.Text = foodTypes[2].ToString();
            textBoxCocaColaPrice.Text = foodTypes[3].ToString();
            customerTimer.Tick += new EventHandler(NextCustomer);
            timeTimer.Tick += new EventHandler(UpdateTime);
            timeTimer.Start();
            panel1.BringToFront();
        }

        string GetLocal(string str)
        {
            return loc.ResourceManager.GetString(str);
        }

        void SetLocalization()
        {
            //Group boxes
            groupBoxTotal1.Text = GetLocal("ToPay" + local);
            groupBoxTotal2.Text = GetLocal("ToPay" + local);
            groupBoxTotal3.Text = GetLocal("ToPayTotal" + local);
            groupBoxCafe.Text = GetLocal("MiniCafe" + local);
            gasBox.Text = GetLocal("Gas" + local);

            //GasBox
            labelOilType.Text = GetLocal("OilType" + local);
            labelOilPrice.Text = GetLocal("Price" + local);
            radioButtonGasAmount.Text = GetLocal("Amount" + local);
            radioButtonGasMoney.Text = GetLocal("Money" + local);

            //Cafe
            labelPrice.Text = GetLocal("Price" + local);
            labelAmount.Text = GetLocal("Amount" + local);
            checkBoxHotDog.Text = GetLocal("HotDog" + local);
            checkBoxHamburger.Text = GetLocal("Hamburger" + local);
            checkBoxFrenchFries.Text = GetLocal("FrenchFries" + local);
            checkBoxCocaCola.Text = GetLocal("CocaCola" + local);

            //Total
            buttonTotal.Text = GetLocal("Calculate" + local);
            labelTotalTotal.Text = GetLocal("TotalDay" + local);

            //Others
            labelChangeColor.Text = GetLocal("ChangeColor" + local);
            toolStripDropDownButton1.Text = GetLocal("DayOfTheWeek" + local);
            toolStripDropDownButton2.Text = GetLocal("BackgroundSettings" + local);
            toolStripDropDownButton3.Text = GetLocal("LanguageSettings" + local);
        }

        public void UpdateTime(Object myObject, EventArgs myEventArgs)
        {
            toolStripStatusLabelDateTime.Text = $"{DateTime.Now}";
            mondayToolStripMenuItem.Text = $"{DateTime.Now.DayOfWeek}";
            this.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }

        public void NextCustomer(Object myObject, EventArgs myEventArgs)
        {
            customerTimer.Stop();
            DialogResult result = MessageBox.Show(GetLocal("Switch2" + local), GetLocal("Switch1" + local), MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
            else if (result == DialogResult.No)
            {
                customerTimer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formsOpened == true)
            {
                MessageBox.Show($"{totalIncome:F2}$", GetLocal("TotalDailyIncome" + local), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                labelCurrency3.Text = "L";
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

        private void OilChanged(object sender, EventArgs e)
        {
            OilUpdate();
        }

        private void CafeChanged(object sender, EventArgs e)
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
            customerTimer.Start();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = panel1.Visible ? false : true;
            panel1.Enabled = panel1.Enabled ? false : true;
        }

        private void trackBarRGB_Scroll(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            panel1.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            statusStrip1.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo((sender as ToolStripMenuItem).Text.ToLower());
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo((sender as ToolStripMenuItem).Text.ToLower());
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(this.GetType());
            resources.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name);
            }
            local = (sender as ToolStripMenuItem).Text;
            SetLocalization();
        }

        private void ResetForm()
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.labelPrice4.Text = totalIncome.ToString("F2");
            customerTimer.Stop();
            form1.totalIncome = totalIncome;
            form1.formsOpened = true;
            formsOpened = false;
            form1.panel1.BackColor = panel1.BackColor;
            form1.statusStrip1.BackColor = statusStrip1.BackColor;
            form1.trackBarR.Value = trackBarR.Value;
            form1.trackBarG.Value = trackBarG.Value;
            form1.trackBarB.Value = trackBarB.Value;
            form1.local = local;
            form1.SetLocalization();
            form1.Show();
            form1.Location = Location;
        }
    }
}
