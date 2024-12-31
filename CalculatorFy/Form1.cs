using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;


namespace CalculatorFy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {

            try
            {


                double cm = double.Parse(txt_total.Text);





                double resault = Math.Pow(cm, 2);
                int remo = lbltotal1.Text.Length;


                string item = txt_total.Text;

                int i = txt_total.Text.Length;
                if (i == 1)
                {
                    while (i >= 1)
                    {
                        lbltotal1.Text = lbltotal1.Text.Remove(remo - i);
                        i--;
                    }
                }
                if (i > 1)
                {
                    do
                    {
                        string men = txt_total.Text;
                        lbltotal1.Text = lbltotal1.Text.Replace(men, "");
                        i--;
                    } while (i > 1);
                }




                txt_total.Text = string.Empty;
                txt_total.Text = resault.ToString();

                bunifuLabel1.Text = resault.ToString();



                lbltotal1.Text += resault.ToString();
            }
            catch
            {
                MessageBox.Show("This format is not correct", "ERORR FORMAT",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            txt_total.Text += ".".ToString();
            bunifuLabel1.Text += ".".ToString();
            lbltotal1.Text += ".".ToString();

        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            txt_total.Text += 0.ToString();
            bunifuLabel1.Text += 0.ToString();
            lbltotal1.Text += 0.ToString();


        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            txt_total.Text += 7.ToString();
            bunifuLabel1.Text += 7.ToString();
            lbltotal1.Text += 7.ToString();

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            txt_total.Text += 8.ToString();
            bunifuLabel1.Text += 8.ToString();
            lbltotal1.Text += 8.ToString();

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            txt_total.Text += 9.ToString();
            bunifuLabel1.Text += 9.ToString();
            lbltotal1.Text += 9.ToString();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            txt_total.Text += 4.ToString();
            bunifuLabel1.Text += 4.ToString();
            lbltotal1.Text += 4.ToString();

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            txt_total.Text += 5.ToString();
            bunifuLabel1.Text += 5.ToString();
            lbltotal1.Text += 5.ToString();

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            txt_total.Text += 6.ToString();
            bunifuLabel1.Text += 6.ToString();
            lbltotal1.Text += 6.ToString();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            txt_total.Text += 1.ToString();
            bunifuLabel1.Text += 1.ToString();
            lbltotal1.Text += 1.ToString();
            

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            txt_total.Text += 2.ToString();
            bunifuLabel1.Text += 2.ToString();
            lbltotal1.Text += 2.ToString();

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            txt_total.Text += 3.ToString();
            bunifuLabel1.Text += 3.ToString();
            lbltotal1.Text += 3.ToString();

        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           
        }

        private void btnmosavi_Click(object sender, EventArgs e)
        {
            try
            {
                string cv = lbltotal1.ToString();
                string remo = "System.Windows.Forms.Label, Text:";
                string next = cv.Replace(remo, "");


                var res = new DataTable().Compute(next, null);
                txt_total.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("This format is not correct", "EROR FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btngam_Click(object sender, EventArgs e)
        {
            bunifuLabel1.Text += "+".ToString();
            txt_total.Text = string.Empty;
            lbltotal1.Text += "+".ToString();



        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            #region betavan2
            double x2 = double.Parse(txt_total.Text);
            int x3 = Convert.ToInt32(x2);
            txt_total.Text = string.Empty;
            double resault = Math.Pow(x2, 2);
            txt_total.Text += resault.ToString();
            #endregion
        }

        private void btnzarb_Click(object sender, EventArgs e)
        {
            
            bunifuLabel1.Text += "x".ToString();
            txt_total.Text = string.Empty;
            lbltotal1.Text += "*".ToString();
        }
       
        
        private void btnradikall_Click(object sender, EventArgs e)
        {
            if(txt_total.Text.Length > 0)
            {
                
                double res = double.Parse(txt_total.Text);
                double sqr = Math.Sqrt(res);
                int bulen = bunifuLabel1.Text.Length;
                int txtlen = txt_total.Text.Length;
                int lenlbl = lbltotal1.Text.Length;


              

                string lentext = txt_total.Text;
                

                bunifuLabel1.Text = bunifuLabel1.Text.Remove(bulen - txtlen);

                lbltotal1.Text = lbltotal1.Text.Replace(lentext, "");
                
              
                txt_total.Text = sqr.ToString();
                bunifuLabel1.Text += txt_total.Text;
                lbltotal1.Text += txt_total.Text;
                
                double re = double.Parse(txt_total.Text);

                

                








            }
            
            
            

            

        }

        private void btnmenha_Click(object sender, EventArgs e)
        {
            bunifuLabel1.Text += "-".ToString();
            txt_total.Text = string.Empty;
            lbltotal1.Text += "-".ToString();
        }

        private void bunifuButtonclear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_total.Text = string.Empty;
                bunifuLabel1.Text = string.Empty;
                lbltotal1.Text = string.Empty;
            }
            catch
            {
                
            }
            
        }

        private void bunifuButtonclearend_Click(object sender, EventArgs e)
        {
            try
            {
                int number = txt_total.Text.Length;
                string textb = txt_total.Text;

                string res = textb.Remove(number - 1);
                txt_total.Text = res;
                lbltotal1.Text = lbltotal1.Text.Remove(number - 1);

                string text2 = bunifuLabel1.Text;
                string res2 = text2.Remove(number - 1);
                bunifuLabel1.Text = res2;
            }
            catch
            {
                MessageBox.Show("This format is not correct", "EROR FORMAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
           
        }

        private void bunifuButtonta_Click(object sender, EventArgs e)
        {
            txt_total.Text = string.Empty;
            bunifuLabel1.Text += "÷".ToString();
            lbltotal1.Text += "/".ToString();


        }

        private void btnmanfy_Click(object sender, EventArgs e)
        {
            bunifuLabel1.Text += "-".ToString();
            txt_total.Text = string.Empty;
            lbltotal1.Text += "-".ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }

}
