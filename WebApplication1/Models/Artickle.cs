namespace WebApplication1.Models
{
	public class Artickle
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string  Image { get; set; }

		public Artickle(int id, string title, string description, string image)
		{
			Id = id;
			Title = title;
			Description = description;
			Image = image;
		}
	}
}
