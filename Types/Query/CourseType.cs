using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class CourseType : ObjectType<Course>
    {
        protected override void Configure(IObjectTypeDescriptor<Course> descriptor)
        {
            descriptor
                .Field<RoundResolver>(resolver => resolver.GetByCourse(default, default))
                .Name("rounds")
                .Type<ListType<RoundType>>();

            descriptor
                .Field<HoleResolver>(resolver => resolver.GetByCourse(default, default))
                .Name("holes")
                .Type<ListType<HoleType>>();

            descriptor
                .Ignore(course => course.Round)
                .Ignore(course => course.Hole);
        }
    }
}
