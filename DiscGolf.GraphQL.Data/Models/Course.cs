using System;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Data.Models
{
    public partial class Course
    {
        public Course()
        {
            Hole = new HashSet<Hole>();
            Round = new HashSet<Round>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hole> Hole { get; set; }
        public virtual ICollection<Round> Round { get; set; }
    }
}
