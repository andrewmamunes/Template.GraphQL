using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class HoleResultType : ObjectType<HoleResult>
    {
        protected override void Configure(IObjectTypeDescriptor<HoleResult> descriptor)
        {
            descriptor
                .Ignore(result => result.Hole)
                .Ignore(result => result.Round)
                .Ignore(result => result.Person);

            descriptor
                .Field<HoleResolver>(resolver => resolver.FetchForHoleResult(default, default))
                .Name("hole")
                .Type<HoleType>();

            descriptor
                .Field<RoundResolver>(resolver => resolver.FetchForHoleResult(default, default))
                .Name("round")
                .Type<RoundType>();

            descriptor
                .Field<PersonResolver>(resolver => resolver.FetchForHoleResult(default, default))
                .Name("person")
                .Type<PersonType>();

        }
    }
}
