using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      // Declare Variables
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*-+";
      int score = 0;

      // Request User To Enter Password
      Console.Write("Enter Password: ");
      string password = Console.ReadLine();

      if (password.Length >= minLength) {
        score++;
      }
      if (Tools.Contains(password, uppercase)) {
        score++;
      }
      if (Tools.Contains(password, lowercase)) {
        score++;
      }
      if (Tools.Contains(password, digits)) {
        score++;
      }
      if (Tools.Contains(password, specialChars)) {
        score++;
      }

      // Display Message Based On Password Score
      switch(score){
        case 5:
          Console.WriteLine("Your Password is the best");
          break;
        case 4:
          Console.WriteLine("Your Password is strong");
          break;
        case 3:
          Console.WriteLine("Your Password is okay");
          break;
        case 2:
          Console.WriteLine("Your Password Could Be Better");
          break;
        case 1:
          Console.WriteLine("Your Password is weak");
          break;
        default:
          Console.WriteLine("Your Password Has None of the requirements");
          break;
      }
    }
  }
}
