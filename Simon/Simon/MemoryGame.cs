using System;
using System.Windows.Forms;

/*This program will be a simple simon-says like memory app.  There are 4 buttons, RYGB, which light
  up.  The human player then has to repeat the sequence correctly.  The player earns one point for each button
  correctly pressed.
*/

/*We will have to move around parts of the program, as Main() will be used to init the GUI.  So we move Main() to Game(), and merge Game() and Init().  We must also create Getters and Setters.
*/

namespace MemoryGame
{
	public class Game
	{
		const int iTEST = 100;
		int[] cseq = new int[iTEST]; //the computer generated sequence
        public int[] TheArray = new int[1000]; //from the tutorial
		private int score;
		private int level;

        private int count;
        private int turn;
        private bool mPlay;
		
		/*Getters and Setters*/
		public int Score
		{
			set {  score = value;  }
			get {  return score;  }
		}
		public int Level
		{
			set {  level = value;  }
			get {  return level;  }
		}
        public int Count
        {
            set { count = value; }
            get { return count; }
        }
        public int Turn
        {
            set { turn = value; }
            get { return turn; }
        }
        public bool Play
        {
            set { mPlay = value; }
            get { return mPlay; }
        }
		public Game()
		{
		/*for testing purposes, cseq is set to a max length of 100.  We generate up to level random numbers, compare cseq to the user input, and if they match, level++, wipe cseq and repeat.
		*/
            score = 0;
            level = 1;
            Random rnd = new Random();

		/*We gen a rand seq until we reach level numbers
		  of rands, then we output the sequence.*/
            for(int i=0; i<level;i++) {  cseq[i] = rnd.Next(0,4);  }
            for (int i = 0; i < 1000; i++) { TheArray[i] = rnd.Next(0, 4); }
            mPlay = false;
            turn = 0;
            count = 0;
		//pass off to lights seq to output
//		DrawItems(ref score, ref level)
//		DisplaySequence(ref cseq);
		  /*Once it is output, we  get user input*/
		  }
        public void GameOver()
        {
            ;
        }
        public void Start()
        {
            mTimer = new Timer();
            mTimer.Interval = 500;  //ms
            mTimer.Tick += new EventHandler(TimerTick);
            mTimer.Enabled = true;
        }
        public void Restart()
        {
            mTimer.Enabled = true;
            mCount = 0;
        }
        public void Stop()
        {
            mTimer.Enabled = false;
            mPlay = true;
            mCount = 0;
        }

        private Timer mTimer;
        public event EventHandler Tick;

        private void TimerTick(object sender, EventArgs e)
        {
            if (Tick != null) { Tick(this, new EventArgs()); }
        }
    }
}
