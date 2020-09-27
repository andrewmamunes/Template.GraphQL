using DiscGolf.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class HoleResultRepository
    {
        private readonly DbSet<HoleResult> HoleResults;
        public HoleResultRepository(GolfContext context)
        {
            HoleResults = context.HoleResult;
        }

        public IEnumerable<HoleResult> GetByRound(int roundId)
        {
            return HoleResults.Where(result => result.RoundId == roundId).AsEnumerable();
        }

        public IEnumerable<HoleResult> GetByPerson(int personId)
        {
            return HoleResults.Where(result => result.PersonId == personId).AsEnumerable();
        }

        public IEnumerable<HoleResult> GetByHole(int holeId)
        {
            return HoleResults.Where(result => result.HoleId == holeId).AsEnumerable();
        }
    }
}
