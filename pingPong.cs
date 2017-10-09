using System;

public class PingPong
{
  public static void Main()
  {
    Console.WriteLine("What's your number?");
    string stringNumber = Console.ReadLine();
    int userNumber = int.Parse(stringNumber);
    for (int number = 0; number <= userNumber; number++)
    {
      if (number % 3 == 0 && number % 5 == 0 && number != 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (number % 5 == 0 && number != 0)
      {
        Console.WriteLine("pong");
      }
      else if (number % 3 == 0 && number != 0)
      {
        Console.WriteLine("ping");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
  }
}
