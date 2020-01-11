using GraphQLDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAll();
    }
}
