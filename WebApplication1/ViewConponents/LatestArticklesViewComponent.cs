using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewConponents
{
	public class LatestArticklesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var Ar = new List<Artickle>
			{
				new Artickle(1,"f","doubll f","blog-post-thumb-card-1.jpg"),
				new Artickle(2,"f2","doubll f","blog-post-thumb-card-2.jpg"),
				new Artickle(3,"f3","doubll f","blog-post-thumb-card-3.jpg"),
				new Artickle(4,"f4","doubll f","blog-post-thumb-card-4.jpg"),
			};
			
			return View("_LatestArtickles",Ar);
		}
	}
}
