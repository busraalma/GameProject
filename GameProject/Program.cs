using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new ValidationManager());
            playerManager.Add(new Player 
            { 
                Id = 1, 
                BirthYear = 1990, 
                FirstName = "Ted", 
                LastName = "Mosby", 
                IdentityNumber = 12345
            });

            Player player = new Player();
            player.FirstName = "smt";
            player.Id = 2;

            Player player2 = new Player();
            player2.FirstName = "ted";
            player2.LastName = "mosby";

            Game game = new Game();
            game.Name = "pacman";

            Game game2 = new Game();
            game2.Name = "mario";

            Campaign campaign = new Campaign();
            campaign.Name = "chrismas";

            SalesManager sales = new SalesManager();
            sales.Sale(player, game);

            SalesManager sales2 = new SalesManager();
            sales2.Sale(player2, game2, campaign);
            
        }
    }
}
