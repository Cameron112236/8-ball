using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_ball
{
    public partial class magic8Ball : Form
    {
        Random ranGen = new Random();
        string fortune;
        int ranNum;
        public magic8Ball()
        {
            InitializeComponent();
        }

        private void magic8Ball_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ranNum= ranGen.Next(1, 7);
            switch(ranNum)
            {
                case 1:
                    playerFortune.Text = "very unlikley";
                    break;
                case 2: playerFortune.Text = "unlikley";
                    break;
                case 3:
                    playerFortune.Text = "possible";
                    break;
                case 4:
                    playerFortune.Text = "likely";
                    break;
                case 5:
                    playerFortune.Text = "very likley";
                    break;
                case 6:
                    playerFortune.Text = "Guarenteed";
                    break;

            }
        }
    }
}
