using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Panel[,] _chessBoardPanels;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.OnPaint += Form1_Paint;
            const int tileSize = 35;
            const int gridSize = 8;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;
            Image myimage = new Bitmap("C:\\Users\\student\\Documents\\Visual Studio 2013\\Projects\\WindowsFormsApplication3\\WindowsFormsApplication3\\Images\\monster.jpg");
            Image myimage1 = new Bitmap(@"C:\Users\student\Documents\Visual Studio 2013\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Images\Sack.jpg");
            _chessBoardPanels = new Panel[gridSize, gridSize];


            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {

                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m)
                    };

                    newPanel.Click += onClick;
                    Controls.Add(newPanel);

                    _chessBoardPanels[n, m] = newPanel;


                    if (n % 2 == 0)
                        newPanel.BackgroundImage = m % 2 != 0 ? myimage : myimage1;
                    else
                        newPanel.BackgroundImage = m % 2 != 0 ? myimage1 : myimage;
                }
            }
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle();
        }
        public void onClick(object sender, EventArgs e)
        {
            var a = sender as Panel;
            var s = a.Location;
            a.Location = new Point(s.X + 35, s.Y);
            Controls.Add(a);
            label1.Text = "Programmer";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
