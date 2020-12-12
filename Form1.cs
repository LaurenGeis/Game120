using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game120
{
    public partial class Form1 : Form
    {
        int controlCount = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
           for (int i = 0; i<controlCount; i++)
            {
                var myButton = new Button();
                myButton.Text = i.ToString();
                myButton.Click += ButtonClickHandler;
                
            }    
           

        }

        private void ButtonClickHandler(object sender, EventArgs e)
        {

        }

        private void MyButton_Click(object sender, EventArgs e)
        {

            var buttonThatWasClicked = sender as Button;
            MessageBox.Show("Congratz, you win, you clicked on the cat");

        }

        private void MyButton_ClickTwo(object sender, EventArgs e)
        {

            var buttonThatWasClicked = sender as Button;
            MessageBox.Show("Sorry, you did not click on the cat. You lose");

        }
    }
}
