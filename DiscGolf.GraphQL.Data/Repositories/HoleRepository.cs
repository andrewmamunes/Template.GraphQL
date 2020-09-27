using DiscGolf.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class HoleRepository
    {
        private readonly DbSet<Hole> Holes;
        public HoleRepository(GolfContext context)
        {
            Holes = context.Hole;
        }

        public IEnumerable<Hole> GetByCourse(int courseId) 
        {
            return Holes.Where(hole => hole.CourseId == courseId);
        }

        public Hole Fetch(int id)
        {
            return Holes.SingleOrDefault(hole => hole.Id == id);
        }
    }
}
