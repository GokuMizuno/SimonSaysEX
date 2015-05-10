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
            gameButton gameButton1 = new gameButton();
            gameButton gameButton2 = new gameButton();
            gameButton gameButton3 = new gameButton();
            gameButton gameButton4 = new gameButton();

            gameButton1.Enabled = false;
            gameButton2.Enabled = false;
            gameButton3.Enabled = false;
            gameButton4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Start")
            {
                this.button1.Enabled = false;

                mGame = new Game();
                mGame.Tick += new EventHandler(GameTick);
                mGame.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                switch(mGame.TheArray[mGame.Count])
                {
                    case 0:
                        this.gameButton1.clicked = true;
                        break;
                    case 1:
                        this.gameButton2.Clicked = true;
                        break;
                    case 3:
                        this.gameButton3.Clicked = true;
                        break;
                    case 4:
                        this.gameButton4.Clicked = true;
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
        {
            this.gameButton1.Clicked = false;
            this.gameButton2.Clicked = false;
            this.gameButton3.Clicked = false;
            this.gameButton4.Clicked = false;
            this.turnOffTimer.Enabled = false;
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            if(mGame.Play == true)
            {
                Button btn = (Button)sender;
                int val = 4;

                switch(btn.Text)
                {
                    case "gameButton1":
                        val = 0;
                        break;
                    case "gameButton2":
                        val = 1;
                        break;
                    case "gameButton3":
                        val = 2;
                        break;
                    case "gameButton4":
                        val = 3;
                        break;
                }

                if(val == mGame.TheArray[mGame.Count])
                {
                    if(mGame.Count < mGame.Turn)  { mGame.Count++; }
                    else
                    {
                        mGame.Play = false;
                        mGame.Turn++;
                        gameButton1.Enabled = false;
                        gameButton2.Enabled = false;
                        gameButton3.Enabled = false;
                        gameButton4.Enabled = false;
                        mGame.Restart();
                    }
                }
                else
                {
                    mGame.GameOver();
                    gameButton1.Enabled = false;
                    gameButton2.Enabled = false;
                    gameButton3.Enabled = false;
                    gameButton4.Enabled = false;
                    this.button1.Enabled = true;
                }
            }
        }

        Point MouseCurrentPos, MouseNewPos, formPos, formNewPos;
        bool mouseDown = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                MouseCurrentPos = Control.MousePosition;
                formPos = Location;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                MouseNewPos = Control.MousePosition;
                formNewPos.X = MouseNewPos.X - MouseCurrentPos.X;
                formNewPos.Y = MouseNewPos.Y - MouseCurrentPos.Y;
                MouseCurrentPos = MouseNewPos;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }
        }
    }
}