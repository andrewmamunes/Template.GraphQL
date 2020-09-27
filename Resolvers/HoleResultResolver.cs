using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using HotChocolate;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Resolvers
{
    public class HoleResultResolver
    {
        public IEnumerable<HoleResult> GetByHole([Parent] Hole hole, [Service] HoleResultRepository repo) 
        {
            return repo.GetByHole(hole.Id);
        }

        public IEnumerable<HoleResult> GetByPerson([Parent] Person person, [Service] HoleResultRepository repo)
        {
            return repo.GetByPerson(person.Id);
        }

        public IEnumerable<HoleResult> GetByRound([Parent] Round round, [Service] HoleResultRepository repo)
        {
            return repo.GetByRound(round.Id);
        }
    }
}
