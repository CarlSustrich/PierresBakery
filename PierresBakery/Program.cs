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
          Program.OrderBread();
        }
        else if (UserInterpretation.meansPastry.Contains(response))
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
        Bread breadOrder = new Bread(numResponse);
        Bread.BreadCost();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your input, {response}, could not be understood. Please enter your response using numbers, not letters.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderBread();
      }
      Console.WriteLine($"Your current bread total is {Bread.CostTotal}.");
      Console.WriteLine($"Your current bread total is {Pastry.CostTotal}.");
      Console.WriteLine("Would you like to order anything else?");
      string orderMoar = Console.ReadLine().ToLower();
      if (UserInterpretation.meansYes.Contains(orderMoar))
      {
        Program.OrderWhat();
      }
      else
      {
        Program.CheckOut();
      }

    }
    static void OrderPastry()
    {
      Console.WriteLine("Pastries are $2 each. Buy 3, get 1 free");
      Console.WriteLine("How many pastries would you like to order?");
      string response = Console.ReadLine();
      if (int.TryParse(response, out int numResponse))
      {
        Pastry pastryOrder = new Pastry(numResponse);
        Pastry.PastryCost();
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your input, {response}, could not be understood. Please enter your response using numbers, not letters.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Program.OrderPastry();
      }
      Console.WriteLine($"Your current bread total is {Bread.CostTotal}.");
      Console.WriteLine($"Your current bread total is {Pastry.CostTotal}.");
      Console.WriteLine("Would you like to order anything else?");
      string orderMoar = Console.ReadLine().ToLower();
      if (UserInterpretation.meansYes.Contains(orderMoar))
      {
        Program.OrderWhat();
      }
      else
      {
        Program.CheckOut();
      }
    }
    static void CheckOut()
    {
      //
    }
  }
}
