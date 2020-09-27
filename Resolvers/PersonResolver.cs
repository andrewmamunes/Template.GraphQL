using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using HotChocolate;

namespace DiscGolf.GraphQL.Resolvers
{
    public class PersonResolver
    {
        public Person FetchForHoleResult([Parent] HoleResult result, [Service] PersonRepository repo) 
        {
            return repo.Fetch(result.PersonId.Value);
        }
    }
}
