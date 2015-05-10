using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        private Game mGame;
        public GameForm()
        {
            InitializeComponent();
            GameButton1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text = "Start")
            {
                this.button1.Enabled = false;

                mGame = new Game();
                mGame.Tick += new EventHandler(GameTick);
                mGame.Start();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Point[] myArray =
            {
                new Point(0,166),
                new Point(9,103),
                new Point(45,45),
                new Point(103,9),
                new Point(166,0)
            };
            Point[] myArray2 =
            {
                new Point(166,0),
                new Point(229,9),
                new Point(287,287),
                new Point(229,393),
                new Point(166,332)
            };
            Point[] myArray3 =
            {
                new Point(332,166),
                new Point(323,229),
                new Point(287,287),
                new Point(229,323),
                new Point(166,332)
            };
            Point[] myArray4 =
            {
                new Point(166,332),
                new Point(103,323),
                new Point(45,287),
                new Point(9,229),
                new Point(0,166)
            };

            GraphicsPath path = new GraphicsPath();
            path.AddCurve(myArray);
            path.AddCurve(myArray2);
            path.AddCurve(myArray3);
            path.AddCurve(myArray4);
            Region reg = new Region(path);
            this.Region = reg;
        }

        private void GameTick(object sender, EventArgs e)
        {
            if(mGame.Score <= mGame.Level)
            {
                switch(mGame.Array)
                {
                    case 0:
                        this.button1.Clicked = true;
                        break;
                    case 1:
                        this.button2.Clicked = true;
                        break;
                    case 3:
                        this.button3.Clicked = true;
                        break;
                    case 4:
                        this.button4.Clicked = true;
                        break;
                    default:
                        break;
                }

                mGame.Count++;
                this.turnOffTimer.Enabled = true;
            }

            if(mGame.Count > mGame.Turn)
            {
                mGame.Stop();

                gameButton1.Enabled = true;
                gameButton2.Enablel = true;
                gameButton3.Enabled = true;
                gameButton4.Enabled = true;
            }
        }

        private void turnOffTimer_Tick(object sender, EventArgs e)
    }
}