using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationService
    {
        bool IValidationService.Validate(Player player)
        {
            if (player.BirthYear == 1990 && player.FirstName == "Ted" && player.LastName == "Mosby" && player.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
        }
    }
}
