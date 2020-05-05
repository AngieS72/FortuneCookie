using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_1FortunCookie
{
    public partial class FormFortuneCookie : Form
    {
        public FormFortuneCookie()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string myFortunes = generateFortune();

            labelFortunes.Text = myFortunes;
        }
        private string generateFortune()
        { 
                string[] fortunes =
        {
            "Birthday are like friends.  The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbows, you will have to tolerate the rain.",
            "The early bird gets the work, the second mouse gets the cheese.",
            " From listening comes wisdom and from speaking repentance.",
            " A smile is your personal welcome mat.",
        };


        Random rand = new Random();     //will let me generate random numbers
        int num1 = rand.Next(0, 7);
            int num2 = rand.Next(0, 7);   //Generate random number between 0 -7

        return (fortunes[num1] + "\n\n" + fortunes[num2]);
            }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelFortunes.Text = "";
            labelFortunes.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            quitProgramNow();
        }
        private void quitProgramNow()
        {
            DialogResult dialog = MessageBox.Show(
                "Do you want to exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
