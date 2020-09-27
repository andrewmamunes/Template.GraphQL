namespace DiscGolf.GraphQL.Data.Repositories.Abstractions
{
    public interface ICreateRepository<T> where T : class
    {
        T Insert(T item);
    }
}
