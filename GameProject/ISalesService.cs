using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        void Sale(Player player, Game game);
        void Sale(Player player, Game game, Campaign campaign);
    }
}
