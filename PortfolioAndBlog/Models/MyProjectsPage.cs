namespace PortfolioAndBlog.Models
{
	public class MyProjectsPage : Identifier
	{
		public string? HeadingPart1 { get; set; }
		public string? HeadingPart2 { get; set; }
		public string? InfoHeading { get; set; }
		public ICollection<MyProject>? Projects { get; set; }
		
	}
}
