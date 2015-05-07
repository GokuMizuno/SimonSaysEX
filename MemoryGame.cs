using System;

/*This program will be a simple simon-says like
  memory app.  There are 4 buttons, RYGB, which light
  up.  The human player then has to repeat the sequence
  correctly.  The player earns one point for each button
correctly pressed.*/


public class Test
{
	public static void Main()
	{
		/*for testing purposes, both cseq and hseq are set to a 
max length of 100.  We generate up to level random numbers, compare the 
sequences, and if they match, level++, wipe cseq and repeat.
		*/
		int iTEST = 100;
		int[] cseq = new int[iTEST]; //the computer generated sequence
		int[] hseq = new int[iTEST]; //the human generated sequence
		int score, level;
		Random rnd = new Random();

		//init game.  Set score to zero, cseq to one.
		Init(out score, out level, out cseq);

		/*Once Init has run, we then begin the game.
		  We gen a rand seq until we reach level numbers
		  of rands, then we output the sequence.*/
		foreach(int i in level)
		{
			cseq[i] = rnd.Next(0,4);
		}
		//pass off to lights seq to output
//		DrawItems(ref score, ref level)
		DisplaySequence(ref cseq);
		  /*Once it is output, we  get user input*/

	}
	public void Init(out int score, out int level, out int cseq)
	{
		level = 0;
		//set GUI clock to zero
		score = 0;
		//set GUI score = 0
	//	sizeof
		//set length of cseq to 1.
		/*Ignored for the moment, see workaround in Main()*/
	}
	public void DisplaySequence(ref int cseq)
	{
		//Just toss out the sequence to see if rnd works
		foreach(int i in cseq)
			Console.WriteLine("{0}", cseq[i]);
	}
}
