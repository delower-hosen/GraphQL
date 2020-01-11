using GraphQL.Types;
using GraphQLDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.GraphQLTypes
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType()
        {
            Field(_ => _.Id);
            Field(_ => _.FirstName);
            // description is an self 
            //explanatory extenstion method which is options
            Field(_ => _.LastName).Description("last name of a player");
            Field(_ => _.CurrentAge);
            Field(_ => _.Teams);
            Field(_ => _.PlayingRole);
            Field(_ => _.BattingStyle);
            Field(_ => _.BowlingStyle);
        }
    }
}
