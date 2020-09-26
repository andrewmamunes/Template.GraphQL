using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            
        }
    }
}
