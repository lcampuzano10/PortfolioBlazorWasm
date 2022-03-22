namespace PortfolioAndBlog.Models
{
    public class Description : Identifier
    {
        public DescriptionHeading? DescriptionHeading { get; set; }
        public string? DescriptionText { get; set; }
        public Guid DescriptionIdMaster { get; set; }
    }
}
