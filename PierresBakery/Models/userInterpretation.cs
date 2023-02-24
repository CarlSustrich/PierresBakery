
using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public abstract class UserInterpretation
  {
    public static List<string> meansDone = new List<string> {"nothing", "done", "checkout", "check out", "no more", "no moar", "i'm allergic to gluten", "do you have anything gluten free?"};
    public static List<string> meansNo = new List<string> {"no", "na", "nope", "n", "no moar"};
    public static List<string> meansYes = new List<string> {"yes", "yea", "y", "yup", "please", "sure", "yespls", "moar", "ye"};
    public static List<string> meansBread = new List<string> { "bread", "breads", "brad", "bred"};
    public static List<string> meansPastry = new List<string> { "pastry", "pastries", "pasty", "pastre", "patry"};
  }
}
