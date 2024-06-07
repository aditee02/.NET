using System;

namespace Restaurant_POS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.closelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MatarPaneertb = new System.Windows.Forms.TextBox();
            this.Rotitb = new System.Windows.Forms.TextBox();
            this.DalTadakatb = new System.Windows.Forms.TextBox();
            this.VegBiryanitb = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MatarPaneercb = new System.Windows.Forms.CheckBox();
            this.Roticb = new System.Windows.Forms.CheckBox();
            this.DalTadakacb = new System.Windows.Forms.CheckBox();
            this.VegBiryanicb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColdCoffeetb = new System.Windows.Forms.TextBox();
            this.Lassitb = new System.Windows.Forms.TextBox();
            this.Sodatb = new System.Windows.Forms.TextBox();
            this.Watertb = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ColdCoffeecb = new System.Windows.Forms.CheckBox();
            this.Lassicb = new System.Windows.Forms.CheckBox();
            this.Sodacb = new System.Windows.Forms.CheckBox();
            this.Watercb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.Grdtotallbl = new System.Windows.Forms.Label();
            this.taxlbl = new System.Windows.Forms.Label();
            this.Subtotallbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_6 = new System.Windows.Forms.TextBox();
            this.label_7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RecieptTb = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Datelbl);
            this.flowLayoutPanel1.Controls.Add(this.closelbl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(250, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(250, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant POS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Datelbl.Location = new System.Drawing.Point(412, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(65, 25);
            this.Datelbl.TabIndex = 4;
            this.Datelbl.Text = "Timer";
            this.Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Datelbl.Click += new System.EventHandler(this.closelbl_Click);
            // 
            // closelbl
            // 
            this.closelbl.AutoSize = true;
            this.closelbl.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closelbl.Location = new System.Drawing.Point(483, 0);
            this.closelbl.Name = "closelbl";
            this.closelbl.Size = new System.Drawing.Size(24, 25);
            this.closelbl.TabIndex = 5;
            this.closelbl.Text = "X";
            this.closelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closelbl.Click += new System.EventHandler(this.closelbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.MatarPaneertb);
            this.panel1.Controls.Add(this.Rotitb);
            this.panel1.Controls.Add(this.DalTadakatb);
            this.panel1.Controls.Add(this.VegBiryanitb);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.MatarPaneercb);
            this.panel1.Controls.Add(this.Roticb);
            this.panel1.Controls.Add(this.DalTadakacb);
            this.panel1.Controls.Add(this.VegBiryanicb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 407);
            this.panel1.TabIndex = 1;
            // 
            // MatarPaneertb
            // 
            this.MatarPaneertb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatarPaneertb.Location = new System.Drawing.Point(148, 117);
            this.MatarPaneertb.Name = "MatarPaneertb";
            this.MatarPaneertb.Size = new System.Drawing.Size(22, 25);
            this.MatarPaneertb.TabIndex = 13;
            this.MatarPaneertb.Text = "0";
            // 
            // Rotitb
            // 
            this.Rotitb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotitb.Location = new System.Drawing.Point(148, 161);
            this.Rotitb.Name = "Rotitb";
            this.Rotitb.Size = new System.Drawing.Size(22, 25);
            this.Rotitb.TabIndex = 12;
            this.Rotitb.Text = "0";
            // 
            // DalTadakatb
            // 
            this.DalTadakatb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DalTadakatb.Location = new System.Drawing.Point(148, 204);
            this.DalTadakatb.Name = "DalTadakatb";
            this.DalTadakatb.Size = new System.Drawing.Size(22, 25);
            this.DalTadakatb.TabIndex = 11;
            this.DalTadakatb.Text = "0";
            // 
            // VegBiryanitb
            // 
            this.VegBiryanitb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VegBiryanitb.Location = new System.Drawing.Point(148, 70);
            this.VegBiryanitb.Name = "VegBiryanitb";
            this.VegBiryanitb.Size = new System.Drawing.Size(22, 25);
            this.VegBiryanitb.TabIndex = 10;
            this.VegBiryanitb.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(48, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 25);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Matar Paneer";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(48, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 25);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Dal Tadaka";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(48, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Roti";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(48, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Veg Biryani";
            // 
            // MatarPaneercb
            // 
            this.MatarPaneercb.AutoSize = true;
            this.MatarPaneercb.Location = new System.Drawing.Point(27, 123);
            this.MatarPaneercb.Name = "MatarPaneercb";
            this.MatarPaneercb.Size = new System.Drawing.Size(15, 14);
            this.MatarPaneercb.TabIndex = 5;
            this.MatarPaneercb.UseVisualStyleBackColor = true;
            this.MatarPaneercb.CheckedChanged += new System.EventHandler(this.MatarPaneercb_CheckedChanged);
            // 
            // Roticb
            // 
            this.Roticb.AutoSize = true;
            this.Roticb.Location = new System.Drawing.Point(27, 172);
            this.Roticb.Name = "Roticb";
            this.Roticb.Size = new System.Drawing.Size(15, 14);
            this.Roticb.TabIndex = 4;
            this.Roticb.UseVisualStyleBackColor = true;
            this.Roticb.CheckedChanged += new System.EventHandler(this.Roticb_CheckedChanged);
            // 
            // DalTadakacb
            // 
            this.DalTadakacb.AutoSize = true;
            this.DalTadakacb.Location = new System.Drawing.Point(27, 215);
            this.DalTadakacb.Name = "DalTadakacb";
            this.DalTadakacb.Size = new System.Drawing.Size(15, 14);
            this.DalTadakacb.TabIndex = 3;
            this.DalTadakacb.UseVisualStyleBackColor = true;
            this.DalTadakacb.CheckedChanged += new System.EventHandler(this.DalTadakacb_CheckedChanged);
            // 
            // VegBiryanicb
            // 
            this.VegBiryanicb.AutoSize = true;
            this.VegBiryanicb.Location = new System.Drawing.Point(27, 76);
            this.VegBiryanicb.Name = "VegBiryanicb";
            this.VegBiryanicb.Size = new System.Drawing.Size(15, 14);
            this.VegBiryanicb.TabIndex = 2;
            this.VegBiryanicb.UseVisualStyleBackColor = true;
            this.VegBiryanicb.CheckedChanged += new System.EventHandler(this.VegBiryanicb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(66, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 407);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.ColdCoffeetb);
            this.panel2.Controls.Add(this.Lassitb);
            this.panel2.Controls.Add(this.Sodatb);
            this.panel2.Controls.Add(this.Watertb);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.ColdCoffeecb);
            this.panel2.Controls.Add(this.Lassicb);
            this.panel2.Controls.Add(this.Sodacb);
            this.panel2.Controls.Add(this.Watercb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(596, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 407);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ColdCoffeetb
            // 
            this.ColdCoffeetb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdCoffeetb.Location = new System.Drawing.Point(152, 70);
            this.ColdCoffeetb.Name = "ColdCoffeetb";
            this.ColdCoffeetb.Size = new System.Drawing.Size(22, 25);
            this.ColdCoffeetb.TabIndex = 14;
            this.ColdCoffeetb.Text = "0";
            // 
            // Lassitb
            // 
            this.Lassitb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lassitb.Location = new System.Drawing.Point(152, 117);
            this.Lassitb.Name = "Lassitb";
            this.Lassitb.Size = new System.Drawing.Size(22, 25);
            this.Lassitb.TabIndex = 13;
            this.Lassitb.Text = "0";
            // 
            // Sodatb
            // 
            this.Sodatb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sodatb.Location = new System.Drawing.Point(152, 161);
            this.Sodatb.Name = "Sodatb";
            this.Sodatb.Size = new System.Drawing.Size(22, 25);
            this.Sodatb.TabIndex = 12;
            this.Sodatb.Text = "0";
            // 
            // Watertb
            // 
            this.Watertb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watertb.Location = new System.Drawing.Point(154, 204);
            this.Watertb.Name = "Watertb";
            this.Watertb.Size = new System.Drawing.Size(22, 25);
            this.Watertb.TabIndex = 11;
            this.Watertb.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(47, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 25);
            this.textBox12.TabIndex = 10;
            this.textBox12.Text = "Cold Coffee";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(50, 117);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(44, 25);
            this.textBox11.TabIndex = 9;
            this.textBox11.Text = "Lassi";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(50, 204);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(44, 25);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "Water";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(50, 166);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(44, 25);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "Soda";
            // 
            // ColdCoffeecb
            // 
            this.ColdCoffeecb.AutoSize = true;
            this.ColdCoffeecb.Location = new System.Drawing.Point(26, 76);
            this.ColdCoffeecb.Name = "ColdCoffeecb";
            this.ColdCoffeecb.Size = new System.Drawing.Size(15, 14);
            this.ColdCoffeecb.TabIndex = 6;
            this.ColdCoffeecb.UseVisualStyleBackColor = true;
            this.ColdCoffeecb.CheckedChanged += new System.EventHandler(this.ColdCoffeecb_CheckedChanged);
            // 
            // Lassicb
            // 
            this.Lassicb.AutoSize = true;
            this.Lassicb.Location = new System.Drawing.Point(26, 123);
            this.Lassicb.Name = "Lassicb";
            this.Lassicb.Size = new System.Drawing.Size(15, 14);
            this.Lassicb.TabIndex = 5;
            this.Lassicb.UseVisualStyleBackColor = true;
            this.Lassicb.CheckedChanged += new System.EventHandler(this.Lassicb_CheckedChanged);
            // 
            // Sodacb
            // 
            this.Sodacb.AutoSize = true;
            this.Sodacb.Location = new System.Drawing.Point(26, 172);
            this.Sodacb.Name = "Sodacb";
            this.Sodacb.Size = new System.Drawing.Size(15, 14);
            this.Sodacb.TabIndex = 4;
            this.Sodacb.UseVisualStyleBackColor = true;
            this.Sodacb.CheckedChanged += new System.EventHandler(this.Sodacb_CheckedChanged);
            // 
            // Watercb
            // 
            this.Watercb.AutoSize = true;
            this.Watercb.Location = new System.Drawing.Point(26, 215);
            this.Watercb.Name = "Watercb";
            this.Watercb.Size = new System.Drawing.Size(15, 14);
            this.Watercb.TabIndex = 3;
            this.Watercb.UseVisualStyleBackColor = true;
            this.Watercb.CheckedChanged += new System.EventHandler(this.Watercb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(55, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(176, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 407);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(194, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 49);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(108, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(250, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Restaurant POS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.Grdtotallbl);
            this.panel6.Controls.Add(this.taxlbl);
            this.panel6.Controls.Add(this.Subtotallbl);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label_6);
            this.panel6.Controls.Add(this.label_7);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(194, 363);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 138);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // Grdtotallbl
            // 
            this.Grdtotallbl.AutoSize = true;
            this.Grdtotallbl.Location = new System.Drawing.Point(218, 25);
            this.Grdtotallbl.Name = "Grdtotallbl";
            this.Grdtotallbl.Size = new System.Drawing.Size(37, 17);
            this.Grdtotallbl.TabIndex = 17;
            this.Grdtotallbl.Text = "Total";
            // 
            // taxlbl
            // 
            this.taxlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.taxlbl.AutoSize = true;
            this.taxlbl.Location = new System.Drawing.Point(126, 25);
            this.taxlbl.Name = "taxlbl";
            this.taxlbl.Size = new System.Drawing.Size(28, 17);
            this.taxlbl.TabIndex = 16;
            this.taxlbl.Text = "Tax";
            // 
            // Subtotallbl
            // 
            this.Subtotallbl.AutoSize = true;
            this.Subtotallbl.Location = new System.Drawing.Point(67, 22);
            this.Subtotallbl.Name = "Subtotallbl";
            this.Subtotallbl.Size = new System.Drawing.Size(25, 17);
            this.Subtotallbl.TabIndex = 15;
            this.Subtotallbl.Text = "Rs.";
            this.Subtotallbl.Click += new System.EventHandler(this.Subtotallbl_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(223, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_6
            // 
            this.label_6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_6.Location = new System.Drawing.Point(160, 22);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(52, 25);
            this.label_6.TabIndex = 11;
            this.label_6.Text = "Rs";
            this.label_6.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label_7
            // 
            this.label_7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_7.Location = new System.Drawing.Point(261, 22);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(55, 25);
            this.label_7.TabIndex = 10;
            this.label_7.Text = "Rs";
            this.label_7.TextChanged += new System.EventHandler(this.grdtotal_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 25);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "SubTotal";
            // 
            // RecieptTb
            // 
            this.RecieptTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecieptTb.Location = new System.Drawing.Point(194, 139);
            this.RecieptTb.Name = "RecieptTb";
            this.RecieptTb.Size = new System.Drawing.Size(402, 226);
            this.RecieptTb.TabIndex = 5;
            this.RecieptTb.Text = "";
            this.RecieptTb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 501);
            this.Controls.Add(this.RecieptTb);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox VegBiryanicb;
        private System.Windows.Forms.CheckBox MatarPaneercb;
        private System.Windows.Forms.CheckBox Roticb;
        private System.Windows.Forms.CheckBox DalTadakacb;
        private System.Windows.Forms.CheckBox ColdCoffeecb;
        private System.Windows.Forms.CheckBox Lassicb;
        private System.Windows.Forms.CheckBox Sodacb;
        private System.Windows.Forms.CheckBox Watercb;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox MatarPaneertb;
        private System.Windows.Forms.TextBox Rotitb;
        private System.Windows.Forms.TextBox DalTadakatb;
        private System.Windows.Forms.TextBox VegBiryanitb;
        private System.Windows.Forms.TextBox ColdCoffeetb;
        private System.Windows.Forms.TextBox Lassitb;
        private System.Windows.Forms.TextBox Sodatb;
        private System.Windows.Forms.TextBox Watertb;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label closelbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox label_6;
        private System.Windows.Forms.TextBox label_7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RecieptTb;
        private System.Windows.Forms.Label Grdtotallbl;
        private System.Windows.Forms.Label taxlbl;
        private System.Windows.Forms.Label Subtotallbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

