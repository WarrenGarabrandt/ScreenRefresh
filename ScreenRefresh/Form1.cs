using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRefresh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color[] rotation = new Color[] 
        {
            Color.Red, Color.Black, Color.White, Color.Black, 
            Color.Blue, Color.Black, Color.White, Color.Black, 
            Color.Green, Color.Black, Color.White, Color.Black,
            Color.Yellow, Color.Black, Color.White, Color.Black,
            Color.Cyan, Color.Black, Color.White, Color.Black,
            Color.Magenta, Color.Black, Color.White, Color.Black, 
            Color.DarkRed, Color.Red, Color.DarkRed, Color.Black,
            Color.DarkBlue, Color.Blue, Color.DarkBlue, Color.Black,
            Color.DarkGreen, Color.Green, Color.DarkGreen, Color.Black,
            Color.FromArgb(128, 128, 0), Color.Yellow, Color.FromArgb(128, 128, 0), Color.Black,
            Color.FromArgb(0, 128, 128), Color.Cyan, Color.FromArgb(0, 128, 128), Color.Black,
            Color.FromArgb(128, 0, 128), Color.Magenta, Color.FromArgb(128, 0, 128), Color.Black,
            Color.Gray, Color.White, Color.Gray, Color.Black
        };

        private int colorRotation = 0;

        private int RandomMode = -1;

        private Random rnd = new Random();

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RandomMode <= 0)
            {
                colorRotation++;
                if (colorRotation >= rotation.Length)
                {
                    RandomMode = 64;
                    colorRotation = 0;
                }
                else
                {
                    this.BackColor = rotation[colorRotation];
                }
            }
            if (RandomMode >= 0)
            {
                RandomMode--;
                this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
    }
}
