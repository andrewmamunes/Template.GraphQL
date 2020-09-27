using DiscGolf.GraphQL.Data.Repositories.Abstractions;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public interface IMutateRepository<T> : IUpdateRepository<T>, ICreateRepository<T> where T : class
    {
    }
}
