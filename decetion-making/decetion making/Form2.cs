using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decetion_making
{
    public partial class Form2 : Form
    {
        Form1 f1;

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = f1.textBox1.Text;
            textBox7.Text = f1.textBox7.Text;
            textBox4.Text = f1.textBox4.Text;
            textBox9.Text = f1.textBox9.Text;
            textBox6.Text = f1.textBox6.Text;
            textBox3.Text = f1.textBox3.Text;
            textBox8.Text = f1.textBox8.Text;
            textBox5.Text = f1.textBox5.Text;
            textBox2.Text = f1.textBox2.Text;


        }

        private void button6_Click(object sender, EventArgs e)
        {

            int text_1 = Convert.ToInt32(textBox1.Text);
            int text_2 = Convert.ToInt32(textBox9.Text);
            int text_3 = Convert.ToInt32(textBox8.Text);
            int text_4 = Convert.ToInt32(textBox7.Text);
            int text_5 = Convert.ToInt32(textBox6.Text);
            int text_6 = Convert.ToInt32(textBox5.Text);
            int text_7 = Convert.ToInt32(textBox4.Text);
            int text_8 = Convert.ToInt32(textBox3.Text);
            int text_9 = Convert.ToInt32(textBox2.Text);



            if (text_1 > text_4 && text_1 > text_7)
            {
                textBox18.Text = (text_1 - text_1).ToString();
                textBox12.Text = (text_1 - text_4).ToString();
                textBox15.Text = (text_1 - text_7).ToString();
            }
            else if (text_4 > text_1 && text_4 > text_7)
            {
                textBox18.Text = (text_4 - text_1).ToString();
                textBox12.Text = (text_4 - text_4).ToString();
                textBox15.Text = (text_4 - text_7).ToString();
            }
            else if (text_7 > text_1 && text_7 > text_4)
            {
                textBox18.Text = (text_7 - text_1).ToString();
                textBox12.Text = (text_7 - text_4).ToString();
                textBox15.Text = (text_7 - text_7).ToString();
            }
            ////////////////////////////////////////////
            if (text_2 > text_5 && text_2 > text_8)
            {
                textBox10.Text = (text_2 - text_2).ToString();
                textBox13.Text = (text_2 - text_5).ToString();
                textBox16.Text = (text_2 - text_8).ToString();
            }
            else if (text_5 > text_2 && text_5 > text_8)
            {
                textBox10.Text = (text_5 - text_2).ToString();
                textBox13.Text = (text_5 - text_5).ToString();
                textBox16.Text = (text_5 - text_8).ToString();
            }
            else if (text_8 > text_2 && text_8 > text_5)
            {
                textBox10.Text = (text_8 - text_2).ToString();
                textBox13.Text = (text_8 - text_5).ToString();
                textBox16.Text = (text_8 - text_8).ToString();
            }
            /////////////////////////////////
            if (text_3 > text_6 && text_3 > text_9)
            {
                textBox11.Text = (text_3 - text_3).ToString();
                textBox14.Text = (text_3 - text_6).ToString();
                textBox17.Text = (text_3 - text_9).ToString();
            }
            else if (text_6 > text_3 && text_6 > text_9)
            {
                textBox11.Text = (text_6 - text_3).ToString();
                textBox14.Text = (text_6 - text_6).ToString();
                textBox17.Text = (text_6 - text_9).ToString();
            }
            else if (text_9 > text_3 && text_9 > text_6)
            {
                textBox11.Text = (text_9 - text_3).ToString();
                textBox14.Text = (text_9 - text_6).ToString();
                textBox17.Text = (text_9 - text_9).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int text_1 = Convert.ToInt32(textBox18.Text);
            int text_2 = Convert.ToInt32(textBox10.Text);
            int text_3 = Convert.ToInt32(textBox11.Text);
            int text_4 = Convert.ToInt32(textBox12.Text);
            int text_5 = Convert.ToInt32(textBox13.Text);
            int text_6 = Convert.ToInt32(textBox14.Text);
            int text_7 = Convert.ToInt32(textBox15.Text);
            int text_8 = Convert.ToInt32(textBox16.Text);
            int text_9 = Convert.ToInt32(textBox17.Text);





            if (text_1 >= text_2 && text_1 >= text_3)
            {
                label17.Text = text_1.ToString();
            }
            else if (text_2 >= text_1 && text_2 >= text_3)
            {
                label17.Text = text_2.ToString();

            }
            else if (text_3 >= text_1 && text_3 >= text_2)
            {
                label17.Text = text_3.ToString();

            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 >= text_5 && text_4 >= text_6)
            {
                label16.Text = text_4.ToString();
            }
            else if (text_5 >= text_4 && text_5 >= text_6)
            {
                label16.Text = text_5.ToString();

            }
            else if (text_6 >= text_4 && text_6 >= text_5)
            {
                label16.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 >= text_8 && text_7 >= text_9)
            {
                label15.Text = text_7.ToString();
            }
            else if (text_8 >= text_7 && text_8 >= text_9)
            {
                label15.Text = text_8.ToString();

            }
            else if (text_9 >= text_7 && text_9 >= text_8)
            {
                label15.Text = text_9.ToString();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int la_1 = Convert.ToInt32(label17.Text);
            int la_2 = Convert.ToInt32(label16.Text);
            int la_3 = Convert.ToInt32(label15.Text);

            if (la_1 < la_2 && la_1 < la_3)
            {
                label7.Text = la_1.ToString();
            }
            else if (la_2 < la_1 && la_2 < la_3)
            {
                label7.Text = la_2.ToString();
            }
            else if (la_3 < la_2 && la_3 < la_1)
            {
                label7.Text = la_3.ToString();
            }
        }
    }
}
