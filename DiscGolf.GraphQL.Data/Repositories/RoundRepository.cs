using DiscGolf.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class RoundRepository
    {
        private readonly DbSet<Round> Rounds;
        public RoundRepository(GolfContext context)
        {
            Rounds = context.Round;
        }

        public Round Fetch(int roundId) 
        {
            return Rounds.FirstOrDefault(round => round.Id == roundId);
        }

        public IEnumerable<Round> GetByCourse (int courseId) 
        {
            return Rounds.Where(round => round.CourseId == courseId).AsEnumerable();
        }
    }
}
