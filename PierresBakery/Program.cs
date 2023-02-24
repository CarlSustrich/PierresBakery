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
      
      Console.WriteLine("We make bread and pastries here, what would you like to order?");
      
      try
      {
        string response = Console.ReadLine().ToLower();
        if (UserInterpretation.meansBread.Contains(response))
        {
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
          Program.OrderBread();
        }
        else if (UserInterpretation.meansPastry.Contains(response))
        {
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
          Program.OrderPastry();
        }
        else if (UserInterpretation.meansDone.Contains(response))
        {
          Program.CheckOut();
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
        Bread breadOrder = new Bread(numResponse);
        Bakery.CalculateCost();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your input, {response}, could not be understood. Please enter your response using numbers, not letters.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderBread();
      }
      Program.OrderMoar();
    }

    static void OrderPastry()
    {
      Console.WriteLine("Pastries are $2 each. Buy 3, get 1 free");
      Console.WriteLine("How many pastries would you like to order?");
      string response = Console.ReadLine();
      if (int.TryParse(response, out int numResponse))
      {
        Pastry pastryOrder = new Pastry(numResponse);
        Bakery.CalculateCost();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your input, {response}, could not be understood. Please enter your response using numbers, not letters.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderPastry();
      }
      Program.OrderMoar();
    }

    static void OrderMoar()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"Your current bread total is {Bakery.BreadTotal}.");
      Console.WriteLine($"Your current bread total is {Bakery.PastryTotal}.");
      Console.WriteLine("Would you like to add more items to your order?");
      string orderMoar = Console.ReadLine().ToLower();
      if (UserInterpretation.meansYes.Contains(orderMoar))
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderWhat();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.CheckOut();
      }
    }

    static void CheckOut()
    {
      Console.WriteLine($"Breads: ${Bakery.BreadTotal}");
      Console.WriteLine($"Pastries: ${Bakery.PastryTotal}");
      Console.WriteLine("------------");
      Console.WriteLine($"${Bakery.BreadTotal + Bakery.PastryTotal}");
      Console.WriteLine("Plz enter all your card info, promise I'm not shady");
      Console.WriteLine("Kidding, please don't. Program ending now");
    }
  }
}
