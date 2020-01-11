using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLDemo.Models;

namespace GraphQLDemo.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public List<Player> GetAll()
        {
            return new List<Player>
            {
                new Player
                {
                    Id=1,
                    FirstName= "Mushfiqur",
                    LastName = "Rahim",
                    CurrentAge = 32,
                    PlayingRole = "Midle-order",
                    BattingStyle = "Right-hand Bat",
                    BowlingStyle="none",
                    Teams="Bangladesh, Rajshahi, Rajshahi Kings"
                }
                // display purpose items hidden , while testing add more items
            };
        }
    }
}
