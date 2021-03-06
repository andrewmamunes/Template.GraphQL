﻿using DiscGolf.GraphQL.DataLoaders;
using HotChocolate;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DiscGolf.GraphQL.Resolvers
{
    public class TestResolver
    {
        public async Task<IReadOnlyList<string>> RunLargeTest(string numberToCreate, [DataLoader] FirstDataLoader firstDataLoader, [DataLoader] SecondDataLoader dataloader, CancellationToken token)
        {
            var numberToCreateAsInteger = int.Parse(numberToCreate);

            var largeTest = new List<string>(numberToCreateAsInteger);

            for (int i = 0; i < numberToCreateAsInteger; ++i)
            {
                largeTest.Add(i.ToString());
            }

            var intermediary = await firstDataLoader.LoadAsync(largeTest, token);

            return await dataloader.LoadAsync(intermediary, token);
        }
    }
}
