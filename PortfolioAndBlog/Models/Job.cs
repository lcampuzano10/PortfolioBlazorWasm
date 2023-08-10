namespace PortfolioAndBlog.Models
{
    public class Job : Identifier
    {
        public string? JobTitle { get; set; }
        public string? Company { get; set; }
        public string? LocationCompany { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public DescriptionHeading DescriptionHeading { get; set; }
        public ICollection<Description>? Descriptions { get; set; }
    }
}
