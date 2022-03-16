namespace PortfolioAndBlog.Models
{
    public class Skill: Identifier
    {
        public DescriptionHeading? DescriptionHeading { get; set; }

        public ICollection<Description>? Descriptions { get; set; }
    }
}
