using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Roticb_CheckedChanged(object sender, EventArgs e)
        {

            if (Roticb.Checked == true)
            {
                Rotitb.Enabled = true;
            }
            if (Roticb.Checked == false)
            {
                Rotitb.Enabled = false;
                Rotitb.Text = "0";
            }
        }

        private void ColdCoffeecb_CheckedChanged(object sender, EventArgs e)
        {

            if (ColdCoffeecb.Checked == true)
            {
                ColdCoffeetb.Enabled = true;
            }
            if (ColdCoffeecb.Checked == false)
            {
                ColdCoffeetb.Enabled = false;
                ColdCoffeetb.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
                timer1.Start();
        }

        private void VegBiryanicb_CheckedChanged(object sender, EventArgs e)
        {
            if(VegBiryanicb.Checked == true) { 
                VegBiryanitb.Enabled = true;
            }else if(VegBiryanicb.Checked != true)
            {
                VegBiryanitb.Enabled = false;
                VegBiryanitb.Text = "0";
            }
           
        }

        private void MatarPaneercb_CheckedChanged(object sender, EventArgs e)
        {
            if (MatarPaneercb.Checked == true)
            {
                MatarPaneertb.Enabled = true;
            }
            if (MatarPaneercb.Checked == false)
            {
                MatarPaneertb.Enabled = false;
                MatarPaneertb.Text = "0";
            }
        }

        private void DalTadakacb_CheckedChanged(object sender, EventArgs e)
        {

            if (DalTadakacb.Checked == true)
            {
                DalTadakatb.Enabled = true;
            }
            if (DalTadakacb.Checked == false)
            {
                DalTadakatb.Enabled = false;
                DalTadakatb.Text = "0";
            }
        }

        private void Lassicb_CheckedChanged(object sender, EventArgs e)
        {
            if (Lassicb.Checked == true)
            {
                Lassitb.Enabled = true;
            }
            if (Lassicb.Checked == false)
            {
                Lassitb.Enabled = false;
                Lassitb.Text = "0";
            }
        }

        private void Sodacb_CheckedChanged(object sender, EventArgs e)
        {
            if (Sodacb.Checked == true)
            {
                Sodatb.Enabled = true;
            }
            if (Sodacb.Checked == false)
            {
                Sodatb.Enabled = false;
                Sodatb.Text = "0";
            }
        }

        private void Watercb_CheckedChanged(object sender, EventArgs e)
        {

            if (Watercb.Checked == true)
            {
                Watertb.Enabled = true;
            }
            if (Watercb.Checked == false)
            {
                Watertb.Enabled = false;
                Watertb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        double VegBiryaniup = 100,MatarPaneerup = 250, Rotiup = 10, DalTadakaup = 150, ColdCoffeeup = 30, Lassiup = 20, Sodaup = 15, Waterup = 10;

        private void Subtotallbl_Click(object sender, EventArgs e)
        {

        }

        private void grdtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VegBiryanicb.Checked = false;
            MatarPaneercb.Checked = false;
            Roticb.Checked = false;
            DalTadakacb.Checked = false;
            ColdCoffeecb.Checked = false;
            Lassicb.Checked = false;
            Sodacb.Checked = false;
            Watercb.Checked = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RecieptTb.Text + " SubTotal " + Subtotallbl.Text + "Tax: " + taxlbl.Text + "Grand Total " + Grdtotallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Black,new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VegBiryanitp = VegBiryaniup * Convert.ToDouble(VegBiryanitb.Text);
            MatarPaneertp = MatarPaneerup * Convert.ToDouble(MatarPaneertb.Text);
            Rotitp = Rotiup * Convert.ToDouble(Rotitb.Text);
            DalTadakatp = DalTadakaup * Convert.ToDouble(DalTadakatb.Text);
            ColdCoffeetp = ColdCoffeeup * Convert.ToDouble(ColdCoffeetb.Text);
            Lassitp = Lassiup * Convert.ToDouble(Lassitb.Text);
            Sodatp = Sodaup * Convert.ToDouble(Sodatb.Text);
            Watertp = Waterup * Convert.ToDouble(Watertb.Text);
            RecieptTb.Clear();
            tax = 0;
            grd_tota1 = 0;
            Subtotal = 0;
            RecieptTb.AppendText(Environment.NewLine);
            RecieptTb.AppendText("\t\t Aditee Restaurent\n" +Datelbl.Text+ Environment.NewLine);
            RecieptTb.AppendText("**************************************************" + Environment.NewLine);

            if (VegBiryanicb.Checked == true)
            {
                RecieptTb.AppendText("\t Veg Biryani:\t" + VegBiryanitp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + VegBiryanitp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (MatarPaneercb.Checked == true)
            {
                RecieptTb.AppendText("\t MatarPaneer:\t" + MatarPaneertp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + MatarPaneertp;
                Subtotallbl.Text = "" + Subtotal;
            }
           if (Roticb.Checked == true)
            {
                RecieptTb.AppendText("\t Roti:\t" + Rotitp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + Rotitp;
                Subtotallbl.Text = "" + Subtotal;
            }
          if (DalTadakacb.Checked == true)
            {
                RecieptTb.AppendText("\t DalTadaka:\t" + DalTadakatp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + DalTadakatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColdCoffeecb.Checked == true)
            {
                RecieptTb.AppendText("\t ColdCoffee:\t" + ColdCoffeetp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + ColdCoffeetp;
                Subtotallbl.Text = "" + Subtotal;
            }
           if (Lassicb.Checked == true)
            {
                RecieptTb.AppendText("\t Lassi:\t" + Lassitp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + Lassitp;
                Subtotallbl.Text = "" + Subtotal;
            }
            else if (Sodacb.Checked == true)
            {
                RecieptTb.AppendText("\t Soda:\t" + Sodatp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + Sodatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (Watercb.Checked == true)
            {
                RecieptTb.AppendText("\t Water:\t" + Watertp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + Watertp;
                Subtotallbl.Text = "" + Subtotal;
            }

            tax = Subtotal * 0.16;
            grd_tota1 = Subtotal + tax;
            label_6.Text =  "Rs."+tax ;
            label_7.Text = "Rs." + grd_tota1;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        double VegBiryanitp, MatarPaneertp, Rotitp, DalTadakatp, ColdCoffeetp, Lassitp, Sodatp, Watertp;
        double Subtotal = 0, tax;
        double grd_tota1;
        private void button2_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
