using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class HoleType : ObjectType<Hole>
    {
        protected override void Configure(IObjectTypeDescriptor<Hole> descriptor)
        {
            descriptor
                .Field<CourseResolver>(resolver => resolver.GetByHole(default, default))
                .Name("course")
                .Type<CourseType>();

            descriptor
                .Field<HoleResultResolver>(resolver => resolver.GetByHole(default, default))
                .Name("results")
                .Type<ListType<HoleResultType>>();

            descriptor
                .Ignore(hole => hole.Course)
                .Ignore(hole => hole.HoleResult);
        }
    }
}
