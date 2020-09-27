using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using HotChocolate;
using System.Collections.Generic;
using System.Linq;

namespace DiscGolf.GraphQL.Types.Resolvers
{
    public class AnalyticsResolver
    {
        public IEnumerable<AnalyticsResult> GetHoleAverage([Parent] Person person, [Service] HoleResultRepository repo) 
        {
            var scores = repo.GetByPerson(person.Id);

            var scoresByHole = scores.GroupBy(result => result.HoleId);

            return scoresByHole
                .Select(scoresForHole => new AnalyticsResult 
                { 
                    HoleId = scoresForHole.Key.Value, 
                    HoleAverage = scoresForHole.ToList().Average(result => result.Score).Value
                });
        }
    }

    public class AnalyticsResult 
    { 
        public int HoleId { get; set; }
        public double HoleAverage { get; set; }
    }
}
