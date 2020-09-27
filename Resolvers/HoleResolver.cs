using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using DiscGolf.GraphQL.Types.Resolvers;
using HotChocolate;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Resolvers
{
    public class HoleResolver
    {
        public IEnumerable<Hole> GetByCourse([Parent] Course course, [Service] HoleRepository repo) 
        {
            return repo.GetByCourse(course.Id);
        }

        public Hole FetchForHoleResult([Parent] HoleResult result, [Service] HoleRepository repo)
        {
            return repo.Fetch(result.HoleId.Value);
        }

        public Hole FetchForAnalytics([Parent] AnalyticsResult result, [Service] HoleRepository repo)
        {
            return repo.Fetch(result.HoleId);
        }

    }
}
