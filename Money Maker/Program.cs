using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();
      double total = CovertToDouble(totalAsString);
      Console.WriteLine($"{total} is eaual to ...");

      // Define Coin Values 
      int goldValue = 10;
      int silverValue = 5;

      // Calculate The Change
      double goldCoins = Math.Floor(total/goldValue);
      double remainder =  total % goldValue;
      
      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = remainder % silverValue;

      // Print Results
      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");


    }
  }
}
