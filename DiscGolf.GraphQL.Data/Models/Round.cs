using System;
using System.Collections.Generic;

namespace DiscGolf.GraphQL.Data.Models
{
    public partial class Round
    {
        public Round()
        {
            HoleResult = new HashSet<HoleResult>();
        }

        public int Id { get; set; }
        public int? CourseId { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<HoleResult> HoleResult { get; set; }
    }
}
