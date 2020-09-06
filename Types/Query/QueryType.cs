using HotChocolate.Resolvers;
using HotChocolate.Types;
using Template.GraphQL.DataLoaders;
using Template.GraphQL.Resolvers;

namespace Template.GraphQL.Types.Query
{
    public class QueryType : ObjectType<RootQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<RootQuery> descriptor)
        {
            descriptor
                .Field("test")
                .Argument("testSize", a => a.Type<NonNullType<HotChocolate.Types.StringType>>())
                .Resolver(ctx => ctx.Resolver<TestResolver>()
                .RunLargeTest(ctx.Argument<string>("testSize"), ctx.DataLoader<FirstDataLoader>(), ctx.DataLoader<SecondDataLoader>(), default));
        }
    }

    public class RootQuery { }
}
