﻿using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
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
            descriptor
                .Field<CourseRepository>(repo => repo.Fetch(default))
                .Argument("courseId", arg => arg.Type<IntType>())
                .Name("course")
                .Type<CourseType>();

        }
    }

    public class RootQuery {
        
    }
}
