namespace PortfolioAndBlog.Models
{
    public class MyJobsPage : Identifier
    {
        public string? HeadingPart1 { get; set; }
        public string? HeadingPart2 { get; set; }
        public string? InfoHeading { get; set; }
        public ICollection<Job>? Jobs { get; set; }
        public ICollection<Skill>? Skills{ get; set; }
        public Education? Education{ get; set; }
    }
}
