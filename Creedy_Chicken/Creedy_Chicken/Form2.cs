using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creedy_Chicken
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // --> mouse hovering <--
            pictureBox1.MouseEnter += OnMouseEnter;
            pictureBox1.MouseLeave += OnMouseLeave;

            pictureBox2.MouseEnter += MouseEnter;
            pictureBox2.MouseLeave += MouseLeave;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {

            pictureBox1.Size = new Size(290, 120);
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(264, 103);

        }
        private void MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.Size = new Size(272, 78);
        }
        private void MouseEnter(object sender, EventArgs e)
        {


            pictureBox2.Size = new Size(250, 90);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // --> form3 appearance for number of players <--
                pictureBox7.Visible = true;
                if (numericUpDown1.Value == 2)
                {
                    pictureBox5.Visible = false;
                    roundPic3.Visible = false;
                    textBox5.Visible = false;
                    label7.Visible = false;
                    pictureBox6.Visible = false;
                    roundPic4.Visible = false;
                    textBox6.Visible = false;
                    label8.Visible = false;
                }
                if (numericUpDown1.Value == 3)
                {
                    pictureBox5.Visible = true;
                    roundPic3.Visible = true;
                    textBox5.Visible = true;
                    label7.Visible = true;
                    pictureBox6.Visible = false;
                    roundPic4.Visible = false;
                    textBox6.Visible = false;
                    label8.Visible = false;
                }
              
                if (numericUpDown1.Value == 4)
                {
                    pictureBox5.Visible = true;
                    roundPic3.Visible = true;
                    textBox5.Visible = true;
                    label7.Visible = true;
                    pictureBox6.Visible = true;
                    roundPic4.Visible = true;
                    textBox6.Visible = true;
                    label8.Visible = true;
                }

                groupBox2.Visible = true;
                groupBox1.Visible = false;


            pictureBox1.Visible = true;


        }

        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;
        }
        // --> data transfering <--
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        


        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 0 && textBox4.TextLength == 0 && textBox5.TextLength == 0 && textBox6.TextLength == 0)
            {
                MessageBox.Show("Please enter nickname", "Error");
            }
            // --> data transfering <--
            
                SetValueForText3 = textBox3.Text;
                SetValueForText4 = textBox4.Text;
                SetValueForText5 = textBox5.Text;
                SetValueForText6 = textBox6.Text;
                decimal x = numericUpDown2.Value;
                decimal a = numericUpDown1.Value;
                Color first = roundPic1.BackColor;
                Color second = roundPic2.BackColor;
                Color third = roundPic3.BackColor;
                Color fourth = roundPic4.BackColor;



            if (textBox3.TextLength > 0 || textBox4.TextLength > 0 || textBox5.TextLength > 0 || textBox6.TextLength > 0)
            {
                // -->  from3 applicating show <--
                this.Hide();
                Form3 f3 = new Form3(x, a, first, second, third, fourth);
                f3.ShowDialog();
                this.Close();
            }

        }

       
        private void roundPic1_Click_1(object sender, EventArgs e)
        {
            // --> Color picker <--
            ColorDialog clr1 = new ColorDialog();
            clr1.ShowDialog();
            roundPic1.BackColor = clr1.Color;
        }

        private void roundPic2_Click(object sender, EventArgs e)
        {
            ColorDialog clr2 = new ColorDialog();
            clr2.ShowDialog();
            roundPic2.BackColor = clr2.Color;
        }

        private void roundPic3_Click(object sender, EventArgs e)
        {
            ColorDialog clr3 = new ColorDialog();
            clr3.ShowDialog();
            roundPic3.BackColor = clr3.Color;
        }
       

        private void roundPic4_Click(object sender, EventArgs e)
        {
            ColorDialog clr4 = new ColorDialog();
            clr4.ShowDialog();
            roundPic4.BackColor = clr4.Color;
        }

       
    }
}
