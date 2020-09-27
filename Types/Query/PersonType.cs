using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using DiscGolf.GraphQL.Types.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            descriptor
                .Ignore(person => person.HoleResult);

            descriptor
                .Field<HoleResultResolver>(repo => repo.GetByPerson(default, default))
                .Name("results")
                .Type<ListType<HoleResultType>>();

            descriptor
                .Field<AnalyticsResolver>(resolver => resolver.GetHoleAverage(default, default))
                .Name("holeAverages")
                .Type<ListType<AnalyticsResultType>>();
        }
    }
}
