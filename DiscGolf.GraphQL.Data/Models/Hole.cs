using System;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Data.Models
{
    public partial class Hole
    {
        public Hole()
        {
            HoleResult = new HashSet<HoleResult>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int Number { get; set; }
        public int Par { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<HoleResult> HoleResult { get; set; }
    }
}
