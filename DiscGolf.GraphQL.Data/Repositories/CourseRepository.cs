using DiscGolf.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class CourseRepository : IMutateRepository<Course>
    {
        private readonly DbSet<Course> Courses;
        public CourseRepository(GolfContext context)
        {
            Courses = context.Course;
        }

        public Course Fetch(int courseId)
        {
            return Courses.SingleOrDefault(course => course.Id == courseId);
        }

        public Course Insert(Course item)
        {
            Courses.Add(item);

            return item;
        }

        public Course Update(Course item)
        {
            Courses.Update(item);

            return item;
        }
    }
}
