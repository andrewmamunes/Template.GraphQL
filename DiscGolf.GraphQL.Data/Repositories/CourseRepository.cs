using DiscGolf.GraphQL.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class CourseRepository
    {
        private readonly GolfContext _context;
        public CourseRepository(GolfContext context)
        {
            _context = context;
        }

        public Course Fetch(int courseId)
        {
            return _context.Course.SingleOrDefault(course => course.Id == courseId);
        }
    }
}
