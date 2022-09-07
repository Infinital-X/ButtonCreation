using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCreation
{
    public partial class Form1 : Form
    {
        Button lastButton;
        bool isPressed = false;
        int startX, startY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                lastButton.Size = new Size(e.X - startX, e.Y - startY);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPressed)
            {
                lastButton = new Button();
                startX = e.X;
                startY = e.Y;
                isPressed = true;
                lastButton.Location = new Point(startX, startY);
                Controls.Add(lastButton);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }
    }
}