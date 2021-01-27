using System;
using System.Collections.Generic;
using System.Text;

namespace SellingAGame_HomeWorkOf5.Day_
{
    class SellManager
    {
        public void Sell(Game game,Gamer gamer)
        {
            Console.WriteLine(game.GameName+" " +":"+" "+"Sold to"+ " " +gamer.GamerFirstName);
        }
            
    }
}
