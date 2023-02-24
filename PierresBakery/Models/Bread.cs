using System;

namespace PierresBakery.Models
{
  public class Bread{
    public int CostTotal {get;set;} = 0;
    public int NumberOfBreads {get;set;}

  public Bread(int num)
  {
    NumberOfBreads = num;
  }

  }
}
