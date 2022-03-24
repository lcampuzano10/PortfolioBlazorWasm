using System.ComponentModel.DataAnnotations;

namespace PortfolioAndBlog.Models
{
    public enum DescriptionHeading
    {
        [Display(Name = "Work Experience")]
        WorkExperience = 1,
        [Display(Name = "Skills")]
        TechnicalSkills,
        [Display(Name = "Education")]
        Education,
        [Display(Name = "Projects")]
        Projects
    }
}
