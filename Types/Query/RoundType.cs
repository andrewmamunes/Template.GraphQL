using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class RoundType : ObjectType<Round>
    {
        protected override void Configure(IObjectTypeDescriptor<Round> descriptor)
        {
            descriptor
                .Field<CourseRepository>(repo => repo.Fetch(default))
                .Name("course")
                .Type<CourseType>();

            descriptor
                .Field<HoleResultResolver>(repo => repo.GetByRound(default, default))
                .Name("results")
                .Type<ListType<HoleResultType>>();

            descriptor
                .Ignore(round => round.Course)
                .Ignore(round => round.HoleResult);
        }
    }
}
