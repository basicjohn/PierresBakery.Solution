using System;
using PierresBakery.Breads;
using PierresBakery.Pastries;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      int caseSwitch = 0;
      Bread NewBread = new Bread("Rustic Loaf");
      Pastry NewPastry = new Pastry("Scone");
      // Console.WriteLine("Welcome to Peirre's Bakery!");
      // Console.WriteLine("THE PLACE for outstanding breads & pastries");
      // int side1 = int.Parse(Console.ReadLine());
      // Console.WriteLine("Please enter the second side of your triangle: ");
      // int side2 = int.Parse(Console.ReadLine());
      // Console.WriteLine("Please enter the third side of your triangle: ");
      // int side3 = int.Parse(Console.ReadLine());
      // Console.WriteLine(newTriangle.CheckType(side1, side2, side3));
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
      Console.WriteLine("");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY!                      ");
      Console.WriteLine("The BEST place for local breads & pastries.      ");
      Console.WriteLine("Follow the instructions to begin with your order.");
      // Console.WriteLine("");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

      caseSwitch = int.Parse(Console.ReadLine());
      switch (caseSwitch)
      {
        case 1:
          Console.WriteLine("You selected Bread!");
          Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
          Console.WriteLine("");
          Console.WriteLine("We have many types of bread but due to the       ");
          Console.WriteLine("pandemic and increased demand we are only        ");
          Console.WriteLine("offering our rustic loaf.                        ");
          Console.WriteLine("-------------------------------------------------");
          Console.WriteLine("They are $5/each and you get the 3rd free        ");
          Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("How many Rustic Loaves would you like?           ");
          break;
        case 2:
          Console.WriteLine("You selected Pastries!");
          Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
          Console.WriteLine("");
          Console.WriteLine("We have many types of bread but due to the       ");
          Console.WriteLine("pandemic and increased demand we are only        ");
          Console.WriteLine("offering our rustic loaf.                        ");
          Console.WriteLine("-------------------------------------------------");
          Console.WriteLine("They are $5/each and you get the 3rd free        ");
          Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––_-");
          Console.WriteLine("How many Rustic Loaves would you like?           ");

          break;
        default:
          Console.WriteLine("Default case");
          break;
      }
    }
  }
}
