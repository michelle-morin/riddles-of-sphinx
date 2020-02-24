using System;
using System.Collections.Generic;

class  RiddlesOfSphinx
{
  public static List<string> riddles = new List<string> { "What is big, red, and eats rocks?", "What walks on four legs in the morning, 2 legs at noon and 3 legs in the evening?", "What is black and white and red all over?", "what do you call a fish missing an eye?" };
  public static List<string> riddleAnswers = new List<string> { "a big red rockeater", "Human", "newspaper", "fsh" };
  static void Main()
  {
    AskRiddle();
  }
  static void AskRiddle()
  {
    var random = new Random();
    var randomNumber = random.Next(0, riddles.Count);
    Console.WriteLine(riddles[randomNumber]);
    string userAnswer  = Console.ReadLine();
    if (userAnswer == riddleAnswers[randomNumber])
    {
      riddles.RemoveAt(randomNumber);
      riddleAnswers.RemoveAt(randomNumber);
      if (riddles.Count == 0)
      {
        Console.WriteLine("you defeated the sphinx!");
      }
      else
      {
        Console.WriteLine("the Sphinx would like to ask you another question!");
        AskRiddle();
      }
    }
    else 
    {
      Console.WriteLine("you have been eaten by the Sphinx!");
    }
  }
}