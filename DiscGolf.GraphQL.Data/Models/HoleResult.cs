namespace DiscGolf.GraphQL.Data.Models
{
    public partial class HoleResult
    {
        public int Id { get; set; }
        public int? HoleId { get; set; }
        public int? RoundId { get; set; }
        public int? PersonId { get; set; }
        public int? Score { get; set; }
        public virtual Hole Hole { get; set; }
        public virtual Person Person { get; set; }
        public virtual Round Round { get; set; }
    }
}
