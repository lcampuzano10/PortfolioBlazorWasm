using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAndBlog.Shared
{
    public partial class Error
    {
		#region Parameter Properties

		[Parameter]
		public RenderFragment ChildContent { get; set; }

		#endregion Parameter Properties

		#region Properties

		#endregion Properties

		#region Methods

		public void ProcessError(Exception ex, String message = null)
		{			
			Console.WriteLine($"Error: {ex.GetType()} , Message: {message} - {ex.Message}");

			Debug.WriteLine($"Error: {ex.GetType()} , Message: {message} - {ex.Message}");
		}

		#endregion Methods
	}
}
