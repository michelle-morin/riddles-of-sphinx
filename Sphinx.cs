using System;
using System.Collections.Generic;

class  RiddlesOfSphinx
{
  public static List<string> riddles = new List<string> { "What is big, red, and eats rocks?", "What walks on four legs in the morning, 2 legs at noon and 3 legs in the evening?", "What is black and white and red all over?", "what do you call a fish missing an eye?", "Never resting, never still; moving silently from hill to hill; it does not walk, run or trot; all is cool where it is not.", "What is large, yet never grows; has roots that cannot be seen; and is taller than trees?", "What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?", "I get light in night dark in day, wet when sunny and dry when rain. If you touch me you can't feel me but if you don't you can feel me. You use me twice a day. Who am I?", "What animal which it's name is three letters long take away the first letter and you have bigger animal.", "What goes up and down the stairs without moving?" };
  public static List<string> riddleAnswers = new List<string> { "a big red rockeater", "human", "newspaper", "fsh", "the sun", "a mountain", "a river", "shadow", "fox", "a stamp" };
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