using DiscGolf.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DiscGolf.GraphQL.Data.Repositories
{
    public class PersonRepository
    {
        private readonly DbSet<Person> People;
        public PersonRepository(GolfContext context)
        {
            People = context.Person;
        }

        public Person Fetch(int personId) 
        {
            return People.FirstOrDefault(person => person.Id == personId);
        }
    }
}
