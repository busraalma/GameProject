using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Sale(Player player, Game game)
        {
            Console.WriteLine("Game " + game.Name + " saled to " + player.FirstName + " " + player.LastName);
        }

        public void Sale(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("Game " + game.Name + " saled to " + player.FirstName + " " + player.LastName + " with campaign " + campaign.Name);
        }
    }
}
