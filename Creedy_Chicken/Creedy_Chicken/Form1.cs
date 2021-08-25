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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           pictureBox1.MouseEnter += OnMouseEnter;
           pictureBox1.MouseLeave += OnMouseLeave;

            pictureBox2.MouseEnter += MouseEnter;
            pictureBox2.MouseLeave += MouseLeave;

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {

            pictureBox1.Size = new Size(250, 90);
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(244, 84);

        }
        private void MouseLeave(object sender, EventArgs e)
        {
            
            pictureBox2.Size = new Size(244, 84);
        }
        private void MouseEnter(object sender, EventArgs e)
        {

            
            pictureBox2.Size = new Size(250, 90);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
