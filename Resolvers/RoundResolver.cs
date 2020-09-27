using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using HotChocolate;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Resolvers
{
    public class RoundResolver
    {
        public IEnumerable<Round> GetByCourse([Parent] Course course, [Service] RoundRepository repo) 
        {
            return repo.GetByCourse(course.Id);
        }

        public Round FetchForHoleResult([Parent] HoleResult result, [Service] RoundRepository repo) 
        {
            return repo.Fetch(result.RoundId.Value);
        }

    }
}
