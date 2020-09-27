using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using HotChocolate;

namespace DiscGolf.GraphQL.Resolvers
{
    public class CourseResolver
    {
        public Course GetByHole([Parent] Hole hole, [Service] CourseRepository repo) 
        {
            return repo.Fetch(hole.CourseId);
        }
    }
}
