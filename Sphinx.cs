using System;

  public class Sphinx
  {
    public static string[] Riddles = {
      "What has a head and a tail, but no body?",
      "What has four wheels and flies?"
    };
    public static string[] Answers = {
      "a coin",
      "a garbage truck"
    };

    public void GameEnd(bool YouWin)
    {
      if(YouWin == true)
      {
        //you win
      }
      else
      {
        //you lose
      }
    }
  }

