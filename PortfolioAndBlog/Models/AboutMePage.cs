using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAndBlog.Models
{
    public class AboutMePage : Identifier
    {        
        public string? HeadingPart1 { get; set; }
        public string? HeadingPart2 { get; set; }
        public string? InfoHeading { get; set; }
        public string? InfoParagraphStart { get; set; }
        public string? InfoParagraphEnd { get; set; }
        public string? InfoPicturePath { get; set; }
    }
}
