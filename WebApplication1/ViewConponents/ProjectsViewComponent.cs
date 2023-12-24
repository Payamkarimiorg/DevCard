using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewConponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var pr = new List<Project>()
			{
			new(1,"taxi","sds","project-1.jpg","ariya"),
			new(2,"taxi2","sds2","project-2.jpg","ariya2"),
			new(3,"taxi3","sds3","project-3.jpg", "ariya3"),
			new(4,"taxi4","sds4","project-4.jpg", "ariya4"),
			};
			return View("_Projects", pr);
		}
	}
}
