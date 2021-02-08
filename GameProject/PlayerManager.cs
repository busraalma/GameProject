using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IValidationService validationService;

        public PlayerManager(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Add(Player player)
        {
            if (validationService.Validate(player) == true)
            {
                Console.WriteLine("Registered");
            }
            else
            {
                Console.WriteLine("Validation failed, registration failed");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " updated");
        }
    }
}
