using PierresBakery.Models;
using System;
using System.Collections.Generic;




namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(Art.WelcomeBanner);
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Program.OrderWhat();
    }

    static void OrderWhat()
    {
      List<string> meansBread = new List<string> { "bread", "breads", "brad", "bred"};
      List<string> meansPastry = new List<string> { "pastry", "pastries", "pasty", "pastre"};

      Console.WriteLine("We make bread and pastries here, what would you like to order?");
      
      try
      {
        string response = Console.ReadLine().ToLower();
        if (meansBread.Contains(response))
        {
          Program.OrderBread();
        }
        else if (meansPastry.Contains(response))
        {
          Program.OrderPastry();
        }
        else 
        {
          throw new ArgumentException(String.Format($"Please check your input and try again, {response} was not understood"));
        }
      }
      catch (ArgumentException e)
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine(e);
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderWhat();
      }
    }
    static void OrderBread()
    {
      Console.WriteLine("Bread loaves are $5 each. Buy 2, get 1 free");
      Console.WriteLine("How many loaves of bread would you like to order?");
      string response = Console.ReadLine();
      if (int.TryParse(response, out int numResponse))
      {
        Console.WriteLine(numResponse);
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your input, {response}, could not be understood. Please enter your response using numbers, not letters.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderBread();
      }
    }
    static void OrderPastry()
    {
      //
    }
  }
}
