using System;
using PierresBakery.Breads;
using PierresBakery.Pastries;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Bread NewBread = new Bread("Rustic Loaf");
      Pastry NewPastry = new Pastry("House Scone");
      Console.WriteLine("");
      Console.WriteLine("______ _                    _      ______       _                   ");
      Console.WriteLine("| ___ (_)                  ( )     | ___ \\     | |                  ");
      Console.WriteLine("| |_/ /_  ___ _ __ _ __ ___|/ ___  | |_/ / __ _| | _____ _ __ _   _ ");
      Console.WriteLine("|  __/| |/ _ \\ '__| '__/ _ \\ / __| | ___ \\/ _` | |/ / _ \\ '__| | | |");
      Console.WriteLine("| |   | |  __/ |  | | |  __/ \\__ \\ | |_/ / (_| |   <  __/ |  | |_| |");
      Console.WriteLine("\\_|   |_|\\___|_|  |_|  \\___| |___/ \\____/ \\__,_|_|\\_\\___|_|   \\__, |");
      Console.WriteLine("                                                               __/ |");
      Console.WriteLine("                                                              |___/ ");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
      Console.WriteLine("");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY!                      ");
      Console.WriteLine("The BEST place for local breads & pastries.      ");
      Console.WriteLine("Follow the instructions below to begin.");
      Console.WriteLine("");
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
      Console.WriteLine("");
      Console.WriteLine("Type '1' for Bread & '2' for Pastries                ");
      int caseSwitch = 0;
      caseSwitch = int.Parse(Console.ReadLine());
      for (int CaseSwitch = 0; CaseSwitch < 4;)
      {
        CaseSwitch = caseSwitch;
        switch (caseSwitch)
        {
          case 1:
            Console.WriteLine("");
            Console.WriteLine("(You've selected Bread!)");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("We have many types of bread but due to the       ");
            Console.WriteLine("pandemic and increased demand we are only        ");
            Console.WriteLine("offering our rustic loaf.                        ");
            Console.WriteLine("");
            Console.WriteLine("They are $5/each and you get the 3rd loaf free        ");
            Console.WriteLine("");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("How many Rustic Loaves would you like?           ");
            NewBread.AddBread(int.Parse(Console.ReadLine()));
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("Type '2' to order Pastries                       ");
            Console.WriteLine("or type '3' to checkout             ");
            caseSwitch = int.Parse(Console.ReadLine());
            break;

          case 2:
            Console.WriteLine("");
            Console.WriteLine("(You've selected Pastries!)");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("We offer many types of pastries but due to the   ");
            Console.WriteLine("pandemic and increased demand we are only        ");
            Console.WriteLine("offering our house scone.                        ");
            Console.WriteLine("");
            Console.WriteLine("They are $2/each and you get the 3rd half price  ");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("How many House Scones would you like?            ");
            NewPastry.AddPastry(int.Parse(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("");
            Console.WriteLine("Type '1' to order Bread                       ");
            Console.WriteLine("or type '3' to checkout             ");
            caseSwitch = int.Parse(Console.ReadLine());
            break;

          case 3:
            NewBread.BreadSubtotal();
            NewPastry.PastrySubtotal();
            if (NewBread.Quantity > 0 && NewPastry.Quantity > 0)
            {
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("We've calculated your order total.  ");
              Console.WriteLine("Below is a break down of your order   ");
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Order Summary");
              Console.WriteLine("=============");
              Console.WriteLine("Rustic Loaves");
              Console.WriteLine("($5/each & get every 3rd free)");
              Console.WriteLine("Price for " + NewBread.Quantity + ": $" + NewBread.BreadsSubtotal + ".00");
              Console.WriteLine("");
              Console.WriteLine("House Scones");
              Console.WriteLine("($2/each & get every 3rd half price)");
              Console.WriteLine("Price for " + NewPastry.Quantity + ": $" + NewPastry.PastriesSubtotal + ".00");
              Console.WriteLine("=============");
              Console.WriteLine("Order Total");
              Console.WriteLine("$" + NewBread.BreadsSubtotal + NewPastry.PastriesSubtotal + ".00");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Thank you for your order. You may close the page now.          ");
              caseSwitch = 4;
            }
            else if (NewBread.Quantity > 0)
            {
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("We've calculated your order total.  ");
              Console.WriteLine("Below is a break down of your order   ");
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Order Summary");
              Console.WriteLine("=============");
              Console.WriteLine("Rustic Loaves");
              Console.WriteLine("($5/each & get every 3rd free)");
              Console.WriteLine("Price for " + NewBread.Quantity + ": $" + NewBread.BreadsSubtotal + ".00");
              Console.WriteLine("=============");
              Console.WriteLine("Order Total");
              Console.WriteLine("$" + NewBread.BreadsSubtotal + ".00");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Thank you for your order. You may close the page now.          ");
              caseSwitch = 4;
            }
            else if (NewPastry.Quantity > 0)
            {
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("We've calculated your order total.  ");
              Console.WriteLine("Below is a break down of your order   ");
              Console.WriteLine("");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Order Summary");
              Console.WriteLine("=============");
              Console.WriteLine("House Scones");
              Console.WriteLine("($2/each & get every 3rd half price)");
              Console.WriteLine("Price for " + NewPastry.Quantity + ": $" + NewPastry.PastriesSubtotal + ".00");
              Console.WriteLine("=============");
              Console.WriteLine("Order Total");
              Console.WriteLine("$" + NewPastry.PastriesSubtotal + ".00");
              Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
              Console.WriteLine("");
              Console.WriteLine("Thank you for your order. You may close the page now.          ");
              caseSwitch = 4;
            }
            else
            {
              Console.WriteLine("Your order is empty     ");
              Console.WriteLine("'1' for Bread");
              Console.WriteLine("'2' for Pastries");
              Console.WriteLine("'4' to exit                ");
              caseSwitch = int.Parse(Console.ReadLine());
            }
            break;
        }
      }
    }
  }
}
