using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace DiscGolf.GraphQL.Types.Query
{
    public class QueryType : ObjectType<RootQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<RootQuery> descriptor)
        {
            
        }
    }

    public class RootQuery {
        [UseSelection]
        public IQueryable<Person> GetPeople([Service] GolfContext context) => context.Person;
        [UseSelection]
        public IQueryable<Round> GetRounds([Service] GolfContext context) => context.Round;
        [UseSelection]
        public IQueryable<Course> GetCourses([Service] GolfContext context) => context.Course;
        [UseSelection]
        public IQueryable<Hole> GetHoles([Service] GolfContext context) => context.Hole;

        

    }
}
