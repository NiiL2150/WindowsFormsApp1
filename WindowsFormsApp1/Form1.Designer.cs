
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gasBox = new System.Windows.Forms.GroupBox();
            this.labelCurrency1 = new System.Windows.Forms.Label();
            this.textBoxOilPrice = new System.Windows.Forms.TextBox();
            this.groupBoxTotal1 = new System.Windows.Forms.GroupBox();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelCurrency3 = new System.Windows.Forms.Label();
            this.labelGasVolume = new System.Windows.Forms.Label();
            this.labelCurrency2 = new System.Windows.Forms.Label();
            this.textBoxGasMoney = new System.Windows.Forms.TextBox();
            this.textBoxGasAmount = new System.Windows.Forms.TextBox();
            this.groupBoxGasAddition = new System.Windows.Forms.GroupBox();
            this.radioButtonGasMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonGasAmount = new System.Windows.Forms.RadioButton();
            this.labelOilPrice = new System.Windows.Forms.Label();
            this.comboBoxOilType = new System.Windows.Forms.ComboBox();
            this.labelOilType = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.groupBoxTotal2 = new System.Windows.Forms.GroupBox();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.labelCurrency4 = new System.Windows.Forms.Label();
            this.textBoxCocaColaAmount = new System.Windows.Forms.TextBox();
            this.textBoxCocaColaPrice = new System.Windows.Forms.TextBox();
            this.textBoxFrenchFriesAmount = new System.Windows.Forms.TextBox();
            this.textBoxFrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.textBoxHamburgerAmount = new System.Windows.Forms.TextBox();
            this.textBoxHamburgerPrice = new System.Windows.Forms.TextBox();
            this.textBoxHotDogAmount = new System.Windows.Forms.TextBox();
            this.textBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxCocaCola = new System.Windows.Forms.CheckBox();
            this.checkBoxFrenchFries = new System.Windows.Forms.CheckBox();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBoxTotal3 = new System.Windows.Forms.GroupBox();
            this.labelTotalTotal = new System.Windows.Forms.Label();
            this.labelPrice4 = new System.Windows.Forms.Label();
            this.labelCurrency6 = new System.Windows.Forms.Label();
            this.labelPrice3 = new System.Windows.Forms.Label();
            this.labelCurrency5 = new System.Windows.Forms.Label();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mondayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelChangeColor = new System.Windows.Forms.Label();
            this.gasBox.SuspendLayout();
            this.groupBoxTotal1.SuspendLayout();
            this.groupBoxGasAddition.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.groupBoxTotal2.SuspendLayout();
            this.groupBoxTotal3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.SuspendLayout();
            // 
            // gasBox
            // 
            this.gasBox.Controls.Add(this.labelCurrency1);
            this.gasBox.Controls.Add(this.textBoxOilPrice);
            this.gasBox.Controls.Add(this.groupBoxTotal1);
            this.gasBox.Controls.Add(this.labelGasVolume);
            this.gasBox.Controls.Add(this.labelCurrency2);
            this.gasBox.Controls.Add(this.textBoxGasMoney);
            this.gasBox.Controls.Add(this.textBoxGasAmount);
            this.gasBox.Controls.Add(this.groupBoxGasAddition);
            this.gasBox.Controls.Add(this.labelOilPrice);
            this.gasBox.Controls.Add(this.comboBoxOilType);
            this.gasBox.Controls.Add(this.labelOilType);
            this.gasBox.Location = new System.Drawing.Point(13, 13);
            this.gasBox.Name = "gasBox";
            this.gasBox.Size = new System.Drawing.Size(221, 209);
            this.gasBox.TabIndex = 0;
            this.gasBox.TabStop = false;
            this.gasBox.Text = "Топливо";
            // 
            // labelCurrency1
            // 
            this.labelCurrency1.AutoSize = true;
            this.labelCurrency1.Location = new System.Drawing.Point(181, 47);
            this.labelCurrency1.Name = "labelCurrency1";
            this.labelCurrency1.Size = new System.Drawing.Size(13, 13);
            this.labelCurrency1.TabIndex = 11;
            this.labelCurrency1.Text = "$";
            // 
            // textBoxOilPrice
            // 
            this.textBoxOilPrice.Enabled = false;
            this.textBoxOilPrice.Location = new System.Drawing.Point(73, 45);
            this.textBoxOilPrice.Name = "textBoxOilPrice";
            this.textBoxOilPrice.Size = new System.Drawing.Size(102, 20);
            this.textBoxOilPrice.TabIndex = 10;
            // 
            // groupBoxTotal1
            // 
            this.groupBoxTotal1.Controls.Add(this.labelPrice1);
            this.groupBoxTotal1.Controls.Add(this.labelCurrency3);
            this.groupBoxTotal1.Location = new System.Drawing.Point(7, 142);
            this.groupBoxTotal1.Name = "groupBoxTotal1";
            this.groupBoxTotal1.Size = new System.Drawing.Size(185, 61);
            this.groupBoxTotal1.TabIndex = 9;
            this.groupBoxTotal1.TabStop = false;
            this.groupBoxTotal1.Text = "К оплате";
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice1.Location = new System.Drawing.Point(89, 16);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice1.Size = new System.Drawing.Size(67, 31);
            this.labelPrice1.TabIndex = 1;
            this.labelPrice1.Text = "0,00";
            // 
            // labelCurrency3
            // 
            this.labelCurrency3.AutoSize = true;
            this.labelCurrency3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency3.Location = new System.Drawing.Point(161, 38);
            this.labelCurrency3.Name = "labelCurrency3";
            this.labelCurrency3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCurrency3.Size = new System.Drawing.Size(18, 20);
            this.labelCurrency3.TabIndex = 0;
            this.labelCurrency3.Text = "$";
            // 
            // labelGasVolume
            // 
            this.labelGasVolume.AutoSize = true;
            this.labelGasVolume.Location = new System.Drawing.Point(163, 88);
            this.labelGasVolume.Name = "labelGasVolume";
            this.labelGasVolume.Size = new System.Drawing.Size(12, 13);
            this.labelGasVolume.TabIndex = 8;
            this.labelGasVolume.Text = "l.";
            // 
            // labelCurrency2
            // 
            this.labelCurrency2.AutoSize = true;
            this.labelCurrency2.Location = new System.Drawing.Point(164, 116);
            this.labelCurrency2.Name = "labelCurrency2";
            this.labelCurrency2.Size = new System.Drawing.Size(13, 13);
            this.labelCurrency2.TabIndex = 7;
            this.labelCurrency2.Text = "$";
            // 
            // textBoxGasMoney
            // 
            this.textBoxGasMoney.Enabled = false;
            this.textBoxGasMoney.Location = new System.Drawing.Point(79, 110);
            this.textBoxGasMoney.Name = "textBoxGasMoney";
            this.textBoxGasMoney.Size = new System.Drawing.Size(78, 20);
            this.textBoxGasMoney.TabIndex = 6;
            this.textBoxGasMoney.Text = "0";
            this.textBoxGasMoney.TextChanged += new System.EventHandler(this.OilChanged);
            // 
            // textBoxGasAmount
            // 
            this.textBoxGasAmount.Location = new System.Drawing.Point(79, 84);
            this.textBoxGasAmount.Name = "textBoxGasAmount";
            this.textBoxGasAmount.Size = new System.Drawing.Size(78, 20);
            this.textBoxGasAmount.TabIndex = 5;
            this.textBoxGasAmount.Text = "0";
            this.textBoxGasAmount.TextChanged += new System.EventHandler(this.OilChanged);
            // 
            // groupBoxGasAddition
            // 
            this.groupBoxGasAddition.Controls.Add(this.radioButtonGasMoney);
            this.groupBoxGasAddition.Controls.Add(this.radioButtonGasAmount);
            this.groupBoxGasAddition.Location = new System.Drawing.Point(6, 74);
            this.groupBoxGasAddition.Name = "groupBoxGasAddition";
            this.groupBoxGasAddition.Size = new System.Drawing.Size(71, 61);
            this.groupBoxGasAddition.TabIndex = 4;
            this.groupBoxGasAddition.TabStop = false;
            // 
            // radioButtonGasMoney
            // 
            this.radioButtonGasMoney.AutoSize = true;
            this.radioButtonGasMoney.Location = new System.Drawing.Point(6, 34);
            this.radioButtonGasMoney.Name = "radioButtonGasMoney";
            this.radioButtonGasMoney.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGasMoney.TabIndex = 1;
            this.radioButtonGasMoney.Text = "Сумма";
            this.radioButtonGasMoney.UseVisualStyleBackColor = true;
            // 
            // radioButtonGasAmount
            // 
            this.radioButtonGasAmount.AutoSize = true;
            this.radioButtonGasAmount.Checked = true;
            this.radioButtonGasAmount.Location = new System.Drawing.Point(6, 10);
            this.radioButtonGasAmount.Name = "radioButtonGasAmount";
            this.radioButtonGasAmount.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGasAmount.TabIndex = 0;
            this.radioButtonGasAmount.TabStop = true;
            this.radioButtonGasAmount.Text = "Кол-во";
            this.radioButtonGasAmount.UseVisualStyleBackColor = true;
            this.radioButtonGasAmount.CheckedChanged += new System.EventHandler(this.OilChanged);
            // 
            // labelOilPrice
            // 
            this.labelOilPrice.AutoSize = true;
            this.labelOilPrice.Location = new System.Drawing.Point(3, 48);
            this.labelOilPrice.Name = "labelOilPrice";
            this.labelOilPrice.Size = new System.Drawing.Size(62, 13);
            this.labelOilPrice.TabIndex = 2;
            this.labelOilPrice.Text = "Стоимость";
            // 
            // comboBoxOilType
            // 
            this.comboBoxOilType.FormattingEnabled = true;
            this.comboBoxOilType.Location = new System.Drawing.Point(73, 20);
            this.comboBoxOilType.Name = "comboBoxOilType";
            this.comboBoxOilType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOilType.TabIndex = 1;
            this.comboBoxOilType.SelectedIndexChanged += new System.EventHandler(this.OilChanged);
            // 
            // labelOilType
            // 
            this.labelOilType.AutoSize = true;
            this.labelOilType.Location = new System.Drawing.Point(1, 20);
            this.labelOilType.Name = "labelOilType";
            this.labelOilType.Size = new System.Drawing.Size(70, 13);
            this.labelOilType.TabIndex = 0;
            this.labelOilType.Text = "Тип топлива";
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.groupBoxTotal2);
            this.groupBoxCafe.Controls.Add(this.textBoxCocaColaAmount);
            this.groupBoxCafe.Controls.Add(this.textBoxCocaColaPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxFrenchFriesAmount);
            this.groupBoxCafe.Controls.Add(this.textBoxFrenchFriesPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxHamburgerAmount);
            this.groupBoxCafe.Controls.Add(this.textBoxHamburgerPrice);
            this.groupBoxCafe.Controls.Add(this.textBoxHotDogAmount);
            this.groupBoxCafe.Controls.Add(this.textBoxHotDogPrice);
            this.groupBoxCafe.Controls.Add(this.labelAmount);
            this.groupBoxCafe.Controls.Add(this.labelPrice);
            this.groupBoxCafe.Controls.Add(this.checkBoxCocaCola);
            this.groupBoxCafe.Controls.Add(this.checkBoxFrenchFries);
            this.groupBoxCafe.Controls.Add(this.checkBoxHamburger);
            this.groupBoxCafe.Controls.Add(this.checkBoxHotDog);
            this.groupBoxCafe.Location = new System.Drawing.Point(240, 13);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(232, 210);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Мини-кафе";
            // 
            // groupBoxTotal2
            // 
            this.groupBoxTotal2.Controls.Add(this.labelPrice2);
            this.groupBoxTotal2.Controls.Add(this.labelCurrency4);
            this.groupBoxTotal2.Location = new System.Drawing.Point(7, 135);
            this.groupBoxTotal2.Name = "groupBoxTotal2";
            this.groupBoxTotal2.Size = new System.Drawing.Size(219, 69);
            this.groupBoxTotal2.TabIndex = 14;
            this.groupBoxTotal2.TabStop = false;
            this.groupBoxTotal2.Text = "К оплате";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice2.Location = new System.Drawing.Point(123, 24);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice2.Size = new System.Drawing.Size(67, 31);
            this.labelPrice2.TabIndex = 3;
            this.labelPrice2.Text = "0,00";
            // 
            // labelCurrency4
            // 
            this.labelCurrency4.AutoSize = true;
            this.labelCurrency4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency4.Location = new System.Drawing.Point(195, 46);
            this.labelCurrency4.Name = "labelCurrency4";
            this.labelCurrency4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrency4.Size = new System.Drawing.Size(18, 20);
            this.labelCurrency4.TabIndex = 2;
            this.labelCurrency4.Text = "$";
            // 
            // textBoxCocaColaAmount
            // 
            this.textBoxCocaColaAmount.Enabled = false;
            this.textBoxCocaColaAmount.Location = new System.Drawing.Point(179, 110);
            this.textBoxCocaColaAmount.Name = "textBoxCocaColaAmount";
            this.textBoxCocaColaAmount.Size = new System.Drawing.Size(47, 20);
            this.textBoxCocaColaAmount.TabIndex = 13;
            this.textBoxCocaColaAmount.Text = "0";
            this.textBoxCocaColaAmount.TextChanged += new System.EventHandler(this.CafeChanged);
            // 
            // textBoxCocaColaPrice
            // 
            this.textBoxCocaColaPrice.Enabled = false;
            this.textBoxCocaColaPrice.Location = new System.Drawing.Point(106, 110);
            this.textBoxCocaColaPrice.Name = "textBoxCocaColaPrice";
            this.textBoxCocaColaPrice.Size = new System.Drawing.Size(47, 20);
            this.textBoxCocaColaPrice.TabIndex = 12;
            // 
            // textBoxFrenchFriesAmount
            // 
            this.textBoxFrenchFriesAmount.Enabled = false;
            this.textBoxFrenchFriesAmount.Location = new System.Drawing.Point(179, 87);
            this.textBoxFrenchFriesAmount.Name = "textBoxFrenchFriesAmount";
            this.textBoxFrenchFriesAmount.Size = new System.Drawing.Size(47, 20);
            this.textBoxFrenchFriesAmount.TabIndex = 11;
            this.textBoxFrenchFriesAmount.Text = "0";
            this.textBoxFrenchFriesAmount.TextChanged += new System.EventHandler(this.CafeChanged);
            // 
            // textBoxFrenchFriesPrice
            // 
            this.textBoxFrenchFriesPrice.Enabled = false;
            this.textBoxFrenchFriesPrice.Location = new System.Drawing.Point(106, 87);
            this.textBoxFrenchFriesPrice.Name = "textBoxFrenchFriesPrice";
            this.textBoxFrenchFriesPrice.Size = new System.Drawing.Size(47, 20);
            this.textBoxFrenchFriesPrice.TabIndex = 10;
            // 
            // textBoxHamburgerAmount
            // 
            this.textBoxHamburgerAmount.Enabled = false;
            this.textBoxHamburgerAmount.Location = new System.Drawing.Point(179, 64);
            this.textBoxHamburgerAmount.Name = "textBoxHamburgerAmount";
            this.textBoxHamburgerAmount.Size = new System.Drawing.Size(47, 20);
            this.textBoxHamburgerAmount.TabIndex = 9;
            this.textBoxHamburgerAmount.Text = "0";
            this.textBoxHamburgerAmount.TextChanged += new System.EventHandler(this.CafeChanged);
            // 
            // textBoxHamburgerPrice
            // 
            this.textBoxHamburgerPrice.Enabled = false;
            this.textBoxHamburgerPrice.Location = new System.Drawing.Point(106, 64);
            this.textBoxHamburgerPrice.Name = "textBoxHamburgerPrice";
            this.textBoxHamburgerPrice.Size = new System.Drawing.Size(47, 20);
            this.textBoxHamburgerPrice.TabIndex = 8;
            // 
            // textBoxHotDogAmount
            // 
            this.textBoxHotDogAmount.Enabled = false;
            this.textBoxHotDogAmount.Location = new System.Drawing.Point(179, 41);
            this.textBoxHotDogAmount.Name = "textBoxHotDogAmount";
            this.textBoxHotDogAmount.Size = new System.Drawing.Size(47, 20);
            this.textBoxHotDogAmount.TabIndex = 7;
            this.textBoxHotDogAmount.Text = "0";
            this.textBoxHotDogAmount.TextChanged += new System.EventHandler(this.CafeChanged);
            // 
            // textBoxHotDogPrice
            // 
            this.textBoxHotDogPrice.Enabled = false;
            this.textBoxHotDogPrice.Location = new System.Drawing.Point(106, 41);
            this.textBoxHotDogPrice.Name = "textBoxHotDogPrice";
            this.textBoxHotDogPrice.Size = new System.Drawing.Size(47, 20);
            this.textBoxHotDogPrice.TabIndex = 6;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(176, 16);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(41, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Кол-во";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(108, 16);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Стоимость";
            // 
            // checkBoxCocaCola
            // 
            this.checkBoxCocaCola.AutoSize = true;
            this.checkBoxCocaCola.Location = new System.Drawing.Point(6, 111);
            this.checkBoxCocaCola.Name = "checkBoxCocaCola";
            this.checkBoxCocaCola.Size = new System.Drawing.Size(51, 17);
            this.checkBoxCocaCola.TabIndex = 3;
            this.checkBoxCocaCola.Text = "Кола";
            this.checkBoxCocaCola.UseVisualStyleBackColor = true;
            this.checkBoxCocaCola.CheckedChanged += new System.EventHandler(this.CafeChanged);
            // 
            // checkBoxFrenchFries
            // 
            this.checkBoxFrenchFries.AutoSize = true;
            this.checkBoxFrenchFries.Location = new System.Drawing.Point(6, 89);
            this.checkBoxFrenchFries.Name = "checkBoxFrenchFries";
            this.checkBoxFrenchFries.Size = new System.Drawing.Size(105, 17);
            this.checkBoxFrenchFries.TabIndex = 2;
            this.checkBoxFrenchFries.Text = "Картофель фри";
            this.checkBoxFrenchFries.UseVisualStyleBackColor = true;
            this.checkBoxFrenchFries.CheckedChanged += new System.EventHandler(this.CafeChanged);
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Location = new System.Drawing.Point(6, 66);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(61, 17);
            this.checkBoxHamburger.TabIndex = 1;
            this.checkBoxHamburger.Text = "Бургер";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            this.checkBoxHamburger.CheckedChanged += new System.EventHandler(this.CafeChanged);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(6, 43);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(64, 17);
            this.checkBoxHotDog.TabIndex = 0;
            this.checkBoxHotDog.Text = "Хот-дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.CafeChanged);
            // 
            // groupBoxTotal3
            // 
            this.groupBoxTotal3.Controls.Add(this.labelTotalTotal);
            this.groupBoxTotal3.Controls.Add(this.labelPrice4);
            this.groupBoxTotal3.Controls.Add(this.labelCurrency6);
            this.groupBoxTotal3.Controls.Add(this.labelPrice3);
            this.groupBoxTotal3.Controls.Add(this.labelCurrency5);
            this.groupBoxTotal3.Controls.Add(this.buttonTotal);
            this.groupBoxTotal3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxTotal3.Location = new System.Drawing.Point(13, 228);
            this.groupBoxTotal3.Name = "groupBoxTotal3";
            this.groupBoxTotal3.Size = new System.Drawing.Size(459, 89);
            this.groupBoxTotal3.TabIndex = 2;
            this.groupBoxTotal3.TabStop = false;
            this.groupBoxTotal3.Text = "Всего к оплате";
            // 
            // labelTotalTotal
            // 
            this.labelTotalTotal.AutoSize = true;
            this.labelTotalTotal.Location = new System.Drawing.Point(334, 19);
            this.labelTotalTotal.Name = "labelTotalTotal";
            this.labelTotalTotal.Size = new System.Drawing.Size(79, 13);
            this.labelTotalTotal.TabIndex = 8;
            this.labelTotalTotal.Text = "Всего за день";
            // 
            // labelPrice4
            // 
            this.labelPrice4.AutoSize = true;
            this.labelPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice4.Location = new System.Drawing.Point(334, 41);
            this.labelPrice4.Name = "labelPrice4";
            this.labelPrice4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice4.Size = new System.Drawing.Size(67, 31);
            this.labelPrice4.TabIndex = 7;
            this.labelPrice4.Text = "0,00";
            // 
            // labelCurrency6
            // 
            this.labelCurrency6.AutoSize = true;
            this.labelCurrency6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency6.Location = new System.Drawing.Point(406, 63);
            this.labelCurrency6.Name = "labelCurrency6";
            this.labelCurrency6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrency6.Size = new System.Drawing.Size(18, 20);
            this.labelCurrency6.TabIndex = 6;
            this.labelCurrency6.Text = "$";
            // 
            // labelPrice3
            // 
            this.labelPrice3.AutoSize = true;
            this.labelPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice3.Location = new System.Drawing.Point(234, 41);
            this.labelPrice3.Name = "labelPrice3";
            this.labelPrice3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrice3.Size = new System.Drawing.Size(67, 31);
            this.labelPrice3.TabIndex = 5;
            this.labelPrice3.Text = "0,00";
            // 
            // labelCurrency5
            // 
            this.labelCurrency5.AutoSize = true;
            this.labelCurrency5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency5.Location = new System.Drawing.Point(306, 63);
            this.labelCurrency5.Name = "labelCurrency5";
            this.labelCurrency5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrency5.Size = new System.Drawing.Size(18, 20);
            this.labelCurrency5.TabIndex = 4;
            this.labelCurrency5.Text = "$";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTotal.Location = new System.Drawing.Point(73, 19);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(125, 64);
            this.buttonTotal.TabIndex = 0;
            this.buttonTotal.Text = "Вычислить";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDateTime,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mondayToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 20);
            this.toolStripDropDownButton1.Text = "День недели";
            this.toolStripDropDownButton1.ToolTipText = "День недели";
            // 
            // mondayToolStripMenuItem
            // 
            this.mondayToolStripMenuItem.Name = "mondayToolStripMenuItem";
            this.mondayToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.mondayToolStripMenuItem.Text = "Monday";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(148, 20);
            this.toolStripDropDownButton2.Text = "Настройки заднего фона";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enToolStripMenuItem,
            this.ruToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(136, 20);
            this.toolStripDropDownButton3.Text = "Языковые настройки";
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            this.enToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enToolStripMenuItem.Text = "EN";
            this.enToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // ruToolStripMenuItem
            // 
            this.ruToolStripMenuItem.Name = "ruToolStripMenuItem";
            this.ruToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ruToolStripMenuItem.Text = "RU";
            this.ruToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.trackBarB);
            this.panel1.Controls.Add(this.trackBarG);
            this.panel1.Controls.Add(this.trackBarR);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelG);
            this.panel1.Controls.Add(this.labelR);
            this.panel1.Controls.Add(this.labelChangeColor);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 323);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // trackBarB
            // 
            this.trackBarB.LargeChange = 32;
            this.trackBarB.Location = new System.Drawing.Point(67, 265);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(366, 45);
            this.trackBarB.SmallChange = 8;
            this.trackBarB.TabIndex = 6;
            this.trackBarB.Value = 255;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarRGB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.LargeChange = 32;
            this.trackBarG.Location = new System.Drawing.Point(67, 187);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(366, 45);
            this.trackBarG.SmallChange = 8;
            this.trackBarG.TabIndex = 5;
            this.trackBarG.Value = 255;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarRGB_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.LargeChange = 32;
            this.trackBarR.Location = new System.Drawing.Point(67, 101);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(366, 45);
            this.trackBarR.SmallChange = 8;
            this.trackBarR.TabIndex = 4;
            this.trackBarR.Value = 255;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarRGB_Scroll);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(26, 265);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(28, 26);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG.Location = new System.Drawing.Point(25, 187);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(30, 26);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "G";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(26, 101);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(29, 26);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "R";
            // 
            // labelChangeColor
            // 
            this.labelChangeColor.AutoSize = true;
            this.labelChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeColor.Location = new System.Drawing.Point(3, 26);
            this.labelChangeColor.Name = "labelChangeColor";
            this.labelChangeColor.Size = new System.Drawing.Size(463, 35);
            this.labelChangeColor.TabIndex = 0;
            this.labelChangeColor.Text = "Поменять цвет заднего фона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 343);
            this.Controls.Add(this.groupBoxCafe);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxTotal3);
            this.Controls.Add(this.gasBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BestOil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gasBox.ResumeLayout(false);
            this.gasBox.PerformLayout();
            this.groupBoxTotal1.ResumeLayout(false);
            this.groupBoxTotal1.PerformLayout();
            this.groupBoxGasAddition.ResumeLayout(false);
            this.groupBoxGasAddition.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.groupBoxCafe.PerformLayout();
            this.groupBoxTotal2.ResumeLayout(false);
            this.groupBoxTotal2.PerformLayout();
            this.groupBoxTotal3.ResumeLayout(false);
            this.groupBoxTotal3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gasBox;
        private System.Windows.Forms.Label labelOilPrice;
        private System.Windows.Forms.ComboBox comboBoxOilType;
        private System.Windows.Forms.Label labelOilType;
        private System.Windows.Forms.Label labelCurrency2;
        private System.Windows.Forms.TextBox textBoxGasMoney;
        private System.Windows.Forms.TextBox textBoxGasAmount;
        private System.Windows.Forms.GroupBox groupBoxGasAddition;
        private System.Windows.Forms.RadioButton radioButtonGasMoney;
        private System.Windows.Forms.RadioButton radioButtonGasAmount;
        private System.Windows.Forms.Label labelGasVolume;
        private System.Windows.Forms.GroupBox groupBoxTotal1;
        private System.Windows.Forms.Label labelCurrency3;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.GroupBox groupBoxCafe;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxCocaCola;
        private System.Windows.Forms.CheckBox checkBoxFrenchFries;
        private System.Windows.Forms.CheckBox checkBoxHamburger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.TextBox textBoxFrenchFriesAmount;
        private System.Windows.Forms.TextBox textBoxHamburgerAmount;
        private System.Windows.Forms.TextBox textBoxHamburgerPrice;
        private System.Windows.Forms.TextBox textBoxHotDogAmount;
        private System.Windows.Forms.TextBox textBoxHotDogPrice;
        private System.Windows.Forms.TextBox textBoxCocaColaAmount;
        private System.Windows.Forms.TextBox textBoxCocaColaPrice;
        private System.Windows.Forms.GroupBox groupBoxTotal2;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Label labelCurrency4;
        private System.Windows.Forms.GroupBox groupBoxTotal3;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Label labelPrice3;
        private System.Windows.Forms.Label labelCurrency5;
        private System.Windows.Forms.TextBox textBoxOilPrice;
        private System.Windows.Forms.Label labelCurrency1;
        private System.Windows.Forms.TextBox textBoxFrenchFriesPrice;
        private System.Windows.Forms.Label labelPrice4;
        private System.Windows.Forms.Label labelCurrency6;
        private System.Windows.Forms.Label labelTotalTotal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mondayToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChangeColor;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruToolStripMenuItem;
    }
}

