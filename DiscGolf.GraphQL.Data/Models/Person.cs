using System;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            HoleResult = new HashSet<HoleResult>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HoleResult> HoleResult { get; set; }
    }
}
