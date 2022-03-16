namespace PortfolioAndBlog.Models
{
    public class MyProjectsPage : Identifier
    {
        public string? HeadingPart1 { get; set; }
        public string? HeadingPart2 { get; set; }
        public string? ProjectPicturePath { get; set; }
        public string? DataTextModal { get; set; }
        public string? ProjectName { get; set; }
        ICollection<ProjectDescription>? ProjectDescriptions { get; set; }
    }
}
