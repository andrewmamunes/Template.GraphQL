using DiscGolf.GraphQL.Resolvers;
using DiscGolf.GraphQL.Types.Resolvers;
using HotChocolate.Types;

namespace DiscGolf.GraphQL.Types.Query
{
    public class AnalyticsResultType : ObjectType<AnalyticsResult>
    {
        protected override void Configure(IObjectTypeDescriptor<AnalyticsResult> descriptor)
        {
            descriptor.Ignore(result => result.HoleId);

            descriptor
                .Field<HoleResolver>(resolver => resolver.FetchForAnalytics(default, default))
                .Name("hole")
                .Type<HoleType>();
        }
    }
}
