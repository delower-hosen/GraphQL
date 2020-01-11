using GraphQL.Types;
using GraphQLDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.GraphQLTypes
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IPlayerRepository _playerRepository)
        {
            Field<ListGraphType<PlayerType>>("players", resolve: context =>
            {
                return _playerRepository.GetAll();
            });
        }
    }
}
