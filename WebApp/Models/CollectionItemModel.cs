﻿namespace WebApp.Models
{
	public class CollectionItemModel
	{
		public int ArticleNumber { get; set; }
		public string ImageUrl { get; set; } = null!;
		public string ProductName { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }
		public int StarRating { get; set; }
		public List<string> Tags { get; set; }
	}
}
