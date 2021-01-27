using System;
using System.Collections.Generic;
using System.Text;

namespace SellingAGame_HomeWorkOf5.Day_
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + "Added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + "Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + "Updated");
        }
    }
}
