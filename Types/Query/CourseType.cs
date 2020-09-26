using DiscGolf.GraphQL.Data.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscGolf.GraphQL.Types.Query
{
    public class CourseType : ObjectType<Course>
    {
        protected override void Configure(IObjectTypeDescriptor<Course> descriptor)
        {
            descriptor
                .Field("rounds")
                .Resolver(ctx => ctx.Service<GolfContext>().Round.Where(round => round.CourseId == ctx.Parent<Course>().Id))
                .Type<ListType<RoundType>>();
        }
    }
}
