using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
	public class Contact
	{
		[Required(ErrorMessage = " پر کردن فیلد اجباری است ")]
		[MinLength(3,ErrorMessage =" حداقل 3 کاراکتر")]
		[MaxLength(100,ErrorMessage = " حداکثر 100 کاراکتر")]

		public string Name { get; set; }

		[Required(ErrorMessage = " پر کردن فیلد اجباری است ")]
		[EmailAddress(ErrorMessage = " مقدار وارد شده ایمیل صحیحی نیست ")]
		public string Email { get; set; }
		public string message { get; set; }
		public string services { get; set; }
    }
}
