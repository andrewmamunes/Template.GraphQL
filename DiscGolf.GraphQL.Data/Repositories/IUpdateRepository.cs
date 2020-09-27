namespace DiscGolf.GraphQL.Data.Repositories
{
    public interface IUpdateRepository<T> where T : class
    {
        T Update(T item);
    }
}
