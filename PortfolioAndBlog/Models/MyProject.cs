namespace PortfolioAndBlog.Models
{
	public class MyProject : Identifier
	{
		public string? ProjectPicturePath { get; set; }
		public string? DataTextModal { get; set; }
		public string? ProjectName { get; set; }
		public string? ProjectNameDescription { get; set; }
		public Description? ProjectDescriptions { get; set; }
	}
}
