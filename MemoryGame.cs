using System;

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
		private int score;
		private int level;
		
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
		//pass off to lights seq to output
//		DrawItems(ref score, ref level)
		DisplaySequence(ref cseq);
		  /*Once it is output, we  get user input*/
		  }
		  
		  public static void Main()
		  {
		  	/*this is a cheap workaround until we can get to a GUI editor, such as VS2013*/
		  	//it doesn't actually work, but, eh, placeholder
		  	Game();
		  }
		  public void DisplaySequence(ref int[] cseq)
		  {
		  	//Just toss out the sequence to see if rnd works
		  	for(int i=0;i<level;i++)
		  	Console.WriteLine("{0}", cseq[i]);
		  }
	}
}
