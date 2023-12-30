using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net;
using System.Net.Mime;

namespace WebApplication1.Controllers
{
	public class Test : Controller
	{
		//public IActionResult Index()
		//{
		//	return Content("<h1> hello </h1>");
		//}
		//public FileResult index()
		//{
		//	var filebyte = System.IO.File.ReadAllBytes("wwwroot/text.txt");
		//	const string fileName = "testfile.txt";
		//	return File(filebyte,MediaTypeNames.Text.Plain, fileName);
		//}
		//public JsonResult index()
		//{
		//	return Json(new

		//	{
		//		id = 1,
		//		Name = "Payam",
		//		job = "Programmer",
		//		age = 21
		//	}
		//	);
		//}
	//	public JavaScriptResult index()
	//	{
	//		return new JavaScriptResult("alert('salam')");
	//	}

	//}
	//public class JavaScriptResult : ContentResult
	
	//{
	

	//	public JavaScriptResult(string Data)
	//	{
	//		Content = Data;
	//		ContentType = "application/javascript";
	//	}

		public IActionResult index()
		{
			return new StatusCodeResult(503);
		}
	}
}
