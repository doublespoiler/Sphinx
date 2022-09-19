using System;
using System.Collections.Generic;
using static Sphinx;

  public class Program 
  {
    public static void Main()
    {
      GameStart();
    }

    public static void GameStart()
    {
      Console.WriteLine("DO YOU WANT TO PLAY A GAME?");
      string answerStart = Console.ReadLine();
      if(answerStart.ToLower() == "y")
      {
        Play();
      }
    }

    public static void Play()
    {
      foreach(String question in Sphinx.Riddles)
      {
        int index = Array.IndexOf(Sphinx.Riddles, question);
        Console.WriteLine("*---------------------------*");
        Console.WriteLine(Sphinx.Riddles[index]);
        string answer = Console.ReadLine();
        if(answer.ToLower() == Sphinx.Answers[index]) //if answer is correct
        {
          if(index == (Sphinx.Riddles.Length - 1)) //if it's the last question
          {
            //game win
            Console.WriteLine("You Win!");
          } 
          else 
          { //continue playing
            Console.WriteLine("The Sphinx looks at you and you think you see it smile.");
            Console.WriteLine("It opens its mouth and asks another question.");
          }
        } 
        else 
        { //answer is wrong
          //game over
          Console.WriteLine("Game Over");
          return;
        }
      }
    }
  }
