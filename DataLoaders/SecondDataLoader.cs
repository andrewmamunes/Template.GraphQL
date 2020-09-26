using GreenDonut;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DiscGolf.GraphQL.Gateways;

namespace DiscGolf.GraphQL.DataLoaders
{
    public class SecondDataLoader : DataLoaderBase<string, string>
    {
        private readonly IEchoGateway _gateway;
        public SecondDataLoader(IEchoGateway gateway) : base(new DataLoaderOptions<string> { MaxBatchSize = 10000 })
        {
            _gateway = gateway;
        }

        protected override Task<IReadOnlyList<Result<string>>> FetchAsync(IReadOnlyList<string> keys, CancellationToken cancellationToken)
        {
            _ = _gateway.Echo(keys.Count);

            var result = keys.Select(key => Result<string>.Resolve(key)).ToList();

            var resultAsReadOnly = result as IReadOnlyList<Result<string>>;

            return Task.FromResult(resultAsReadOnly);
        }
    }
}
