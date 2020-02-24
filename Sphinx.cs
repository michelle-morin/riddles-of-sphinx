using System;

class  RiddlesOfSphinx
{
  static void Main()
  {
    Console.WriteLine("What is big, red, and eats rocks?");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "a big red rockeater")
    {
      Console.WriteLine("you defeated the Sphinx!");
      Console.WriteLine("What walks on four legs in the morning, 2 legs at noon and 3 legs in the evening?");
      userAnswer = Console.ReadLine();
      if (userAnswer == "Human")
      {
        Console.WriteLine("you defeated the Sphinx!");
      }
      else
      {
        Console.WriteLine("you have been eaten by the Sphinx!");
      }
    }
    else
    {
      Console.WriteLine("you have been eaten by the Sphinx!");
    }
  }
}