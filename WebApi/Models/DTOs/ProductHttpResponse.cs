﻿using WebApi.Models.Entities.Data;

namespace WebApi.Models.DTOs
{
	public class ProductHttpResponse
	{
		public string ArticleNumber { get; set; } = null!;
		public string ProductName { get; set; } = null!;
		public string? Description { get; set; }
		public decimal Price { get; set; }

        public ICollection<TagEntity> Tags { get; set; } = new HashSet<TagEntity>();

    }
}
