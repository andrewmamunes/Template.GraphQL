using GreenDonut;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Template.GraphQL.DataLoaders
{
    public class FirstDataLoader : DataLoaderBase<string, string>
    {
        public FirstDataLoader() : base(new DataLoaderOptions<string> { MaxBatchSize = 50 })
        {

        }
        protected override Task<IReadOnlyList<Result<string>>> FetchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            var test = keys.Count;

            var result = keys.Select(key => Result<string>.Resolve(key)).ToList();

            var resultAsReadOnly = result as IReadOnlyList<Result<string>>;

            return Task.FromResult(resultAsReadOnly);
        }
    }
}
