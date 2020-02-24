using System;
using System.Collections.Generic;

class  RiddlesOfSphinx
{
  static void Main()
  {
    AskRiddle();
  }
  static void AskRiddle()
  {
    string[] riddles = { "What is big, red, and eats rocks?", "What walks on four legs in the morning, 2 legs at noon and 3 legs in the evening?", "What is black and white and red all over?", "what do you call a fish missing an eye?" };
    string[] riddleAnswers = { "a big red rockeater", "Human", "newspaper", "fsh" };
    var random = new Random();
    var randomNumber = random.Next(0, 3);
    Console.WriteLine(riddles[randomNumber]);
    string userAnswer  = Console.ReadLine();
    if (userAnswer == riddleAnswers[randomNumber])
    {
      Console.WriteLine("you defeated the Sphinx!");
      AskRiddle();
    }
    else 
    {
      Console.WriteLine("you have been eaten by the Sphinx!");
    }
  }
}