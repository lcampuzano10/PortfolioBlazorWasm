namespace PortfolioAndBlog.Models
{
    public class Education: Identifier
    {
        public string? Degree { get; set; }
        public string? SchoolName { get; set; }
        public string? LocationSchool { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public DescriptionHeading? DescriptionHeading { get; set; }

        //public ICollection<Description>? Descriptions { get; set; }
    }
}
