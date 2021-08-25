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
    public partial class Form3 : Form
    {
        int index = 0;
        bool isSaved = false;
        int roll;
        public Form3(decimal x, decimal a, Color first, Color second, Color third, Color fourth)
        {
            // --> Transfering data between two windows <-- 
            InitializeComponent();
            int y = Convert.ToInt32(x);
            label5.Text = y.ToString();
            label6.Text = a.ToString();
            if(a == 2)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                roundPic2.Visible = false;
                roundPic4.Visible = false;
                label11.Visible = false;
                label22.Visible = false;
                label19.Visible = false;
                label12.Visible = false;
                label17.Visible = false;
                label13.Visible = false;
                label20.Visible = false;
                label14.Visible = false;

            }
            if (a == 3)
            {
                
                pictureBox4.Visible = false;
                
                label4.Visible = false;
                
                roundPic4.Visible = false;
                label17.Visible = false;
                label13.Visible = false;
                label20.Visible = false;
                label14.Visible = false;
                

            }
            // --> this roundpic box is creating for looks good of view and it looks like as profile photo <-- 
            roundPic1.BackColor = first;
            roundPic2.BackColor = second;
            roundPic3.BackColor = third;
            roundPic4.BackColor = fourth;

            // --> this is mose hover and it is more similar from java script actually I've created these for save button(if save button is disable then button is not able to hover <--
            pictureBox5.MouseEnter += OnMouseEnter;
            pictureBox5.MouseLeave += OnMouseLeave;

            pictureBox6.MouseEnter += MouseEnter;
            pictureBox6.MouseLeave += MouseLeave;

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {

            pictureBox5.Size = new Size(350, 120);
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(319, 103);

        }
        private void MouseLeave(object sender, EventArgs e)
        {

            pictureBox6.Size = new Size(319, 102);
        }
        private void MouseEnter(object sender, EventArgs e)
        {


            pictureBox6.Size = new Size(350, 120);
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            // --> these is for data transfering also <--
            label1.Text = Form2.SetValueForText3;
            label3.Text = Form2.SetValueForText4;
            label2.Text = Form2.SetValueForText5;
            label4.Text = Form2.SetValueForText6;
           
            


        }


        int previous,current;
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // --> here is wonning screen and it is too simple just find player and display name of player <--
            timer1.Start();
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            if (int.Parse(label15.Text) >= int.Parse(label5.Text))
            {
                label24.Visible = true;
                label24.Text = label1.Text + " Won! \nThanks for Playing, Please Close The Program!";
            }
            if (int.Parse(label9.Text) >= int.Parse(label5.Text))
            {
                label24.Visible = true;
                label24.Text = label3.Text + " Won! \nThanks for Playing, Please Close The Program!";
            }
            if (int.Parse(label11.Text) >= int.Parse(label5.Text))
            {
                label24.Visible = true;
                label24.Text = label2.Text + " Won! \nThanks for Playing, Please Close The Program!";
            }
            if (int.Parse(label13.Text) >= int.Parse(label5.Text))
            {
                label24.Visible = true;
                label24.Text = label4.Text + " Won! \nThanks for Playing, Please Close The Program!";
            }
        }
       
        
      
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // --> here is most important part on all program please pay attention of this place Thank you <--
            
           // --> first part is random part as you may see just it choose number randomly from list box(list box contains of dice photos) <--
                Random rnd3 = new Random();
                timer1.Stop();
                 roll = rnd3.Next(0, 5);
                pictureBox7.Visible = true;
                pictureBox7.Image = imageList1.Images[roll];

            // --> as you may see there are a lot of things in that part here is game over part whaen any player reach goal then everthing become dissapeared <--
            if (int.Parse(label15.Text) >= int.Parse(label5.Text) || int.Parse(label9.Text) >= int.Parse(label5.Text) || int.Parse(label11.Text) >= int.Parse(label5.Text) || int.Parse(label13.Text) >= int.Parse(label5.Text))
            {
                // --> you can ask why I didn't use methot, it is too easy becase there is no another code like that and I didn't need to create method for once use code <--
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                roundPic2.Visible = false;
                roundPic4.Visible = false;
                label11.Visible = false;
                label22.Visible = false;
                label19.Visible = false;
                label12.Visible = false;
                label17.Visible = false;
                label13.Visible = false;
                label20.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label18.Visible = false;
                label1.Visible = false;
                label16.Visible = false;
                label9.Visible = false;
                label21.Visible = false;
                label10.Visible = false;
                label3.Visible = false;
                label23.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                roundPic1.Visible = false;
                roundPic3.Visible = false;



            }

            


          // --> here is queue part as you may see it turns player by player I'm going to explain everthing on there <--

            switch (index)
            {
                // -->in here there are 4 case every case is representing one player <--
                    case 0:
                    
                    previous = Convert.ToInt32(label15.Text);
                    
                    
                    if(isSaved == false || isSaved == true && roll + 1 >= Convert.ToInt32(label18.Text))
                    {
                        // --> why roll + 1? because as you may know listbox beging from 0 and thre ase 6 face of dice so if you want to get actual number then you have to add 1 to random list number <--
                        
                        previous += roll + 1;
                        label15.Text = previous.ToString();

                    }
                   // --> in every time bank balance turns 0 <--
                    label18.Text = 0.ToString();
                    label23.Text = "Player 1 turns";
                    break;

                    case 1:
                    previous = Convert.ToInt32(label9.Text);
                    if (isSaved == false || isSaved == true && roll + 1 >= Convert.ToInt32(label10.Text))
                    {
                        
                        previous += roll + 1;
                        label9.Text = previous.ToString();

                    }
                    label10.Text = 0.ToString();

                    label23.Text = "Player 2 turns";
                    break;

                   case 2:
                    previous = Convert.ToInt32(label11.Text);
                    if (isSaved == false || isSaved == true && roll + 1 >= Convert.ToInt32(label12.Text))
                    {
                        
                        previous += roll + 1;
                        label11.Text = previous.ToString();

                    }
                    label12.Text = 0.ToString();

                    label23.Text = "Player 3 turns;";
                    break;

                   case 3:
                    previous = Convert.ToInt32(label13.Text);
                    
                    if (isSaved == false || isSaved == true && roll + 1 >= Convert.ToInt32(label14.Text))
                    {
                        
                        previous += roll + 1;
                        label13.Text = previous.ToString();

                    }
                    label14.Text = 0.ToString();





                    label23.Text = "Player 4 turns";
                    break;

            }
            
            // --> what is index and why it is increasing? so index is player number and in every roll player is change except save button <--
            index++;
            if (isSaved == false)
            {
                pictureBox6.Enabled = true;
            }
            else
            {
                isSaved = false;

            }

            // --> if player number is 2 so when index turns 2 then it gone 0 cuz we have two player <--
            if (index == Convert.ToInt32(label6.Text))
            {
                index = 0;
            }

            
        }

       

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // --> here is save button, a bit complacated but really easy system <--
            if (pictureBox6.Enabled == true)
            {
                isSaved = true;

                pictureBox6.Enabled = false;

                // --> if you click save it is going to go back so if you are 3rd player and you are going to become 4th player it is going back 3rd player againg <--
                index--;
                if(index == -1)
                {
                    index = Convert.ToInt32(label6.Text) - 1;
                }
                switch(index)
                {
                    // --> here is for banking system so easy just it put back from point and add bank account <--
                    case 0:
                        label15.Text = (Convert.ToInt32(label15.Text) - roll - 1).ToString();
                        label18.Text = (Convert.ToInt32(label18.Text) + roll + 1).ToString();
                        break;
                    case 1:
                        label9.Text = (Convert.ToInt32(label9.Text) - roll - 1).ToString();
                        label10.Text = (Convert.ToInt32(label10.Text) + roll + 1).ToString();
                        break;
                    case 2:
                        label11.Text = (Convert.ToInt32(label11.Text) - roll - 1).ToString();
                        label12.Text = (Convert.ToInt32(label12.Text) + roll + 1).ToString();
                        break;
                    case 3:
                        label13.Text = (Convert.ToInt32(label13.Text) - roll - 1).ToString();
                        label14.Text = (Convert.ToInt32(label14.Text) + roll + 1).ToString();
                        break;



                }
            }









        }
    }
}

// --> THANKS FOR REVIEWING CODE. THIS CODE PREPARING BY BAKHTIYAR AGHAYEV FOR SOME DISEASE PROBLEMS(COVID-19) MY CODE HAS BEEN LATE BUT IT IS OK NOW. <--
