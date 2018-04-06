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
<<<<<<< HEAD
        private Panel[,] _chessBoardPanels;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
            const int tileSize = 35;
            const int gridSize = 8;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;
            Image myimage = new Bitmap(@"C:\Users\1\source\repos\WindowsFormsTrain\WindowsFormsTrain\Images\Monster.png");
            Image myimage1 = new Bitmap(@"C:\Users\1\source\repos\WindowsFormsTrain\WindowsFormsTrain\Images\Sack.png");
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
            //e.Graphics.DrawString()
        }
        public void onClick(object sender, EventArgs e)
        {
            //e.Graphics.DrawString()
        }

=======
>>>>>>> 7c7eff38e02e32b22bbc9ebb20e20f2de68e6aed
    }
}
