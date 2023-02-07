using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30);
       sam.SetHobbies(new string[]{"hockey","games","racing"});
    }
  }
}
