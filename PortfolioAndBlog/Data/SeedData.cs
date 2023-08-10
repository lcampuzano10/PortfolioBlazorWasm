using PortfolioAndBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAndBlog.Data
{
	public static class SeedData
	{
		public static AboutMePage AboutMeInfo = new()
		{
			Id = new Guid("c89571da-a4ec-4746-950a-940957b0df63"),
			HeadingPart1 = "About",
			HeadingPart2 = "Me",
			InfoHeading = "Biography",
			InfoParagraphStart = "Highly skilled and dedicated .NET Core Software Developer with over ",
			InfoParagraphEnd = @"+ years of experience in developing robust Console Applications, 
									web application using Blazor, MVC, API with JWT token and Identity Security, and WinForms using .NET Core 5, 
									6, and 7, C# and MS SQL. Skilled in architecting and executing customized, data-driven solutions, 
									hosted on-premises and Cloud. Knowledge of Entity Framework Core, Razor pages, Mapster, Dapper, JSON, 
									Visual Studio, Azure and Postman. Seeking a challenging role to utilize my expertise and contribute to the success 
									of an innovative software development team.",
			InfoPicturePath = "img/portrait.jpg"
		};

		//TODO: Finish the skills			- LC 03/21/22
		//public static List<Skill> SkillInfo = new List<Skill>
		//{

		//};

		public static List<Education> EducationInfo = new()
		{
			new Education
			{
				Id = new Guid(),
				Degree = "Bachelor of Science in Information Technology",
				SchoolName = "University of South Florida",
				LocationSchool = "Tampa, FL",
				DateStarted	= new DateTime(2016,08,16),
				DateFinished = new DateTime(2020,05, 14),
				DescriptionHeading = DescriptionHeading.Education
			},
			new Education
			{
				Id = new Guid(),
				Degree = "Associate in Science in Information Technology",
				SchoolName = "Bergen Community College",
				LocationSchool = "Paramus, NJ",
				DateStarted = new DateTime(2011, 09, 16),
				DateFinished = new DateTime(2014, 06, 14),
				DescriptionHeading = DescriptionHeading.Education
			}
		};

		public static Skill SkillInfo = new()
		{
			Id = new Guid(),
			DescriptionHeading = DescriptionHeading.TechnicalSkills,
			Descriptions = new List<Description>
			{
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Highly proficient in development systems using C# language and OOP.",
					DescriptionIdMaster= new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Expertise in operating Visual Studio .NET for testing and debugging.",
					DescriptionIdMaster= new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Proficient in .Net 6, .Net 5, HTML5, CSS, JavaScript, Bootstrap, and IIS 7.0+ .",
					DescriptionIdMaster = new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Proficient in JSON, RESTful APIs, LINQ.",
					DescriptionIdMaster = new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Proficient on Azure DevOps using version control Git commands and TFS using VS Team Explorer.",
					DescriptionIdMaster = new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Proficient in Database Design, scripting, SSIS and store procedure using T-SQL and SQL Server.",
					DescriptionIdMaster = new Guid()
				},
				new Description
				{
					DescriptionHeading = DescriptionHeading.TechnicalSkills,
					DescriptionText = @"Skilled at working with Docker and third party’s API like Twilio.",
					DescriptionIdMaster = new Guid()
				}
			}
		};

		public static List<MyJobsPage> MyJobsInfo = new()
		{
			new MyJobsPage
			{
				Id = new Guid("758d9623-ad02-404f-9f26-77f45ad43fe6"),
				HeadingPart1 = "My",
				HeadingPart2 = "Work",
				InfoHeading = "WORK EXPERIENCE",
				Jobs = new List<Job>
				{
					new Job
					{
						Id =  new Guid("663a1191-5ac4-4822-9455-656c01b13ddc"),
						DescriptionHeading = DescriptionHeading.WorkExperience,
						JobTitle = "C# Developer",
						Company = "Buddy's Home Furnishing",
						LocationCompany = "Tampa, FL",
						DateStarted = new DateTime(2021,10,01),
						DateFinished = DateTime.Now,
						//DateFinished = new DateTime(),
						Descriptions = new List<Description>
						{
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Lead C# developer on a Blazor Server project that increase company 
									and franchises revenue more than 50% by signing agreements electronically.",
								DescriptionIdMaster = new Guid("663a1191-5ac4-4822-9455-656c01b13ddc")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Create personal projects using Blazor Wasm, deployed them to Github pages, 
									also deployed to Azure App Service using blob storage container for saving files.",
								DescriptionIdMaster = new Guid("663a1191-5ac4-4822-9455-656c01b13ddc")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Developed software components with other developers on the team using Azure 
									DevOps (TFS) for committing my changes, using Jira for assigning task.",
								DescriptionIdMaster = new Guid("663a1191-5ac4-4822-9455-656c01b13ddc")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Investigated, debugged and fixed applications problems reported by quality 
									assurance department to ensure optimal development environment.",
								DescriptionIdMaster = new Guid("663a1191-5ac4-4822-9455-656c01b13ddc")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Worked with SQL server stored procedures created by the DBA, reviewing and 
									understanding the process inside those stored procedures and returning feedback if changes are needed.",
								DescriptionIdMaster = new Guid("663a1191-5ac4-4822-9455-656c01b13ddc")
							}
						}

					},
					new Job
					{
						Id =  new Guid("4756a1c0-d3ce-4cb0-af5d-bea9ee007f4b"),
						DescriptionHeading = DescriptionHeading.WorkExperience,
						JobTitle = "Application Developer",
						Company = "Kimball Electronics Tampa",
						LocationCompany = "Tampa, FL",
						DateStarted = new DateTime(2020,09,10),
						DateFinished = new DateTime(2021,09,28),
						//DateFinished = new DateTime(),
						Descriptions = new List<Description>
						{
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Developed a .Net 5 MVC website to replace a legacy ASP.NET VB.net website requested 
									by a client. Using DI, Onion Architecture, Hangfire Task Schedule, Serilog Logging on file and a Database this help the client to move forward with the latest technology available.",
								DescriptionIdMaster = new Guid("4756a1c0-d3ce-4cb0-af5d-bea9ee007f4b")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Investigated, debugged and fixed applications problems reported by senior developer or 
									clients to ensure optimal development environment.",
								DescriptionIdMaster = new Guid("4756a1c0-d3ce-4cb0-af5d-bea9ee007f4b")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"In charge of Deploying to IIS an application created on Sencha (Javascript Framework) 
									as well to do the necessaries changes on a WebAPI (Net Framework 4.6) to be deployed into the same IIS and be able to connect with the Sencha Application and vice versa, also in charge of testing manually the Sencha Application.",
								DescriptionIdMaster = new Guid("4756a1c0-d3ce-4cb0-af5d-bea9ee007f4b")
							}
						}

					},
					new Job
					{
						Id =  new Guid("9b68a968-3343-4556-9472-bf627cfd3a46"),
						DescriptionHeading = DescriptionHeading.WorkExperience,
						JobTitle = "Junior Software Developer",
						Company = "Tenex Software Solution",
						LocationCompany = "Tampa, FL",
						DateStarted = new DateTime(2020,06,1),
						DateFinished = new DateTime(2020,09,1),
						Descriptions = new List<Description>
						{
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Develop code per detailed specifications using specified programming languages, 
									tools, and techniques under the direction of the project manager or team leader.",
								DescriptionIdMaster = new Guid("9b68a968-3343-4556-9472-bf627cfd3a46")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Investigated, debugged and fixed applications problems reported by quality 
									assurance to ensure optimal development environment.",
								DescriptionIdMaster = new Guid("9b68a968-3343-4556-9472-bf627cfd3a46")
							}
						}

					},
					new Job
					{
						Id =  new Guid("152550f3-f7e9-4a73-ba69-ee9cbce0534b"),
						DescriptionHeading = DescriptionHeading.WorkExperience,
						JobTitle =  "Junior Software Developer",
						Company = "Mid Atlantic Finance",
						LocationCompany = "Clearwater, FL",
						DateStarted = new DateTime(2016,07,1),
						DateFinished = new DateTime(2020,03,1),
						Descriptions = new List<Description>
						{
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Boosted the productivity of the Collection Department by 85% daily by creating 
									a Win Forms C# app where they search a customer account, export the information to a PDF, and mailing it.",
								DescriptionIdMaster = new Guid("152550f3-f7e9-4a73-ba69-ee9cbce0534b")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Maximized the IT personnel 25 minutes every month by Developing a monthly Task 
									on a C# console application where search and copy PDF files from one location to another.",
								DescriptionIdMaster = new Guid("152550f3-f7e9-4a73-ba69-ee9cbce0534b")
							},
							new Description
							{
								Id = new Guid(),
								DescriptionHeading = DescriptionHeading.WorkExperience,
								DescriptionText = @"Developed a program in C# allowing the IT Department to resolve regular open 
									tickets, it increases their productivity by 55%.",
								DescriptionIdMaster = new Guid("152550f3-f7e9-4a73-ba69-ee9cbce0534b")
							}
						}

					}
				}

			},
			//new MyJobsPage
			//{
			//	Id = new Guid("cc5e9880-197f-461c-9f83-4b52bffbc4df"),
			//	HeadingPart1 = "My",
			//	HeadingPart2 = "Work",
			//	InfoHeading = "SKILLS"
			//}
		};

		public static MyProjectsPage MyProjectsInfo = new()
		{
			Id = new Guid("56fd592e-8a49-41cb-a402-7accd9f35822"),
			HeadingPart1 = "My",
			HeadingPart2 = "Projects",
			InfoHeading = "Check some of my Projects...",
			Projects = new List<MyProject>
			{
				new MyProject
				{
					Id = new Guid("1eee4c77-f255-46c7-b3a1-946090201c5e"),
					ProjectNameDescription = "Rating System .Net Core MVC",
					ProjectName = "Rating Systems",
					ProjectPicturePath = "img/projects/RatingSystem.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"An MVC website project using ASP.NET Framework where it searches on
							the database using Entity Framework for a range of accounts, calculate
							the rating using a library created by another developer and shows on a
							table information retrieved, once the user updates the rating the
							application will write back to another table, i also was in charge of
							deployment to the IIS Server.",
						DescriptionIdMaster = new Guid("1eee4c77-f255-46c7-b3a1-946090201c5e")
					}
				},
				new MyProject
				{
					Id = new Guid("0a8ecf5d-22f0-47ac-8b39-12786581f69f"),
					ProjectNameDescription = "Unzip WinForm",
					ProjectName = "Walz UnZip",
					ProjectPicturePath = "img/projects/WalzUnzip.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"An windows forms on C# and .Net Framework where users can see, select,
						and extract a zip file into their local or Domain user Desktop on
						their machine or server from a list of zip files within a network
						location.",
						DescriptionIdMaster = new Guid("0a8ecf5d-22f0-47ac-8b39-12786581f69f")
					}
				},
				new MyProject
				{
					Id = new Guid("cbeca9e2-f40f-4202-859a-99a36085f4ca"),
					ProjectNameDescription = "Mail Merge Win Form",
					ProjectName = "Mail Merge",
					ProjectPicturePath = "img/projects/MailMerge.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"A visual interface program in C# that increase users productivity by
						55% by letting the users create spreadsheets base on accounts or
						dealers from a database and save it automatically on an spreadsheet,
						so other user can create a mail merge document and print them.",
						DescriptionIdMaster = new Guid("cbeca9e2-f40f-4202-859a-99a36085f4ca")
					}
				},
				new MyProject
				{
					Id = new Guid("6fa55c13-0937-45c9-b23b-a0bbbc4fd34b"),
					ProjectNameDescription = "SQL Search Win Form",
					ProjectName = "SQL Search",
					ProjectPicturePath = "img/projects/gifForGitHub.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"A program in C# allowing the IT Department to resolve regular open
						tickets, it increases their productivity by 45%",
						DescriptionIdMaster = new Guid("6fa55c13-0937-45c9-b23b-a0bbbc4fd34b")
					}
				},
				new MyProject
				{
					Id = new Guid("46975288-5ee1-4fbb-b97e-bb300c61883d"),
					ProjectNameDescription = "Company Directory .Net MVC",
					ProjectName = "Company Directory",
					ProjectPicturePath = "img/projects/CompanyDirectory.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"Increase company user’s searches by 30% by developing an ASP.NET
						website where it searches for Windows Active Directory Users and
						update a DataGrid with the information obtained so users can look for
						any employee on the Intranet.",
						DescriptionIdMaster = new Guid("46975288-5ee1-4fbb-b97e-bb300c61883d")
					}
				},
				new MyProject
				{
					Id = new Guid("35295d7f-5bc9-49c7-837d-bcf9246b370b"),
					ProjectNameDescription = "Admin Win Form",
					ProjectName = "Admin",
					ProjectPicturePath = "img/projects/Admin.gif",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"A visual interface program in C# allowing the Collection Department to
						search an account and based on the State, creates a PDF with the
						customer information, with option of print it, this increase their
						productivity by 85% daily.",
						DescriptionIdMaster = new Guid("35295d7f-5bc9-49c7-837d-bcf9246b370b")
					}
				},
				new MyProject
				{
					Id = new Guid("8f785f8e-1214-4f2a-b41b-8fc6790f6aa1"),
					ProjectNameDescription = "Others Projects",
					ProjectName = "Others Projects",
					ProjectPicturePath = "img/projects/otherProjects.jpg",
					ProjectDescriptions = new Description
					{
						Id = new Guid(),
						DescriptionHeading = DescriptionHeading.Projects,
						DescriptionText = @"Others Projects have been created and will be added later.",
						DescriptionIdMaster = new Guid("8f785f8e-1214-4f2a-b41b-8fc6790f6aa1")
					}
				},
			}
		};
	}
}
