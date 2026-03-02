using BDF.LunchOrder.BL.Models;
using NuGet.Configuration;

namespace BDF.LunchOrder.BL
{
    public static class LunchItemManager
    {
        public static List<LunchItem> Populate()
        {
            return new List<LunchItem> {
                new LunchItem {
                    Id = 1,
                    Description = "Hamburger",
                    Cost = 6.95,
                    AddOnCost = .75,
                    AddOnItems = new List<AddOnItem> {
                        new AddOnItem {Id = 1, Description = "Lettuce" },
                        new AddOnItem {Id = 2, Description = "Tomato" },
                        new AddOnItem {Id = 3, Description = "Onions" }
                    }
                },
                new LunchItem {
                    Id = 2,
                    Description = "Pizza",
                    Cost = 5.95,
                    AddOnCost = .5,
                    AddOnItems = new List<AddOnItem> {
                        new AddOnItem {Id = 1, Description = "Pepperoni" },
                        new AddOnItem {Id = 2, Description = "Sausage" },
                        new AddOnItem {Id = 3, Description = "Olives" }
                    }
                },
                new LunchItem {
                    Id = 3,
                    Description = "Salad",
                    Cost = 4.95,
                    AddOnCost = .25 ,
                    AddOnItems = new List<AddOnItem> {
                        new AddOnItem {Id = 1, Description = "Croutons" },
                        new AddOnItem {Id = 2, Description = "Bacon Bits" },
                        new AddOnItem {Id = 3, Description = "Bread Sticks" }
                    }
                }
            };
        }
    }
}
