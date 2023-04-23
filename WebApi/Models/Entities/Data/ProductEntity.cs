using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApi.Models.DTOs;
using WebApi.Models.Entities.Identity;

namespace WebApi.Models.Entities.Data
{
    public class ProductEntity
    {
        [Key]
        public int ArticleNumber { get; set; }
        public string ProductName { get; set; } = null!;
		public string? Description { get; set; }

		[Column(TypeName = "money")]
        public decimal Price { get; set; }
		public int StarRating { get; set; }
		public string? ImageURL { get; set; }


		public TagEntity Tag { get; set; } = null!;



        public static implicit operator ProductHttpResponse(ProductEntity entity)
		{
			return new ProductHttpResponse
			{
				ArticleNumber = entity.ArticleNumber,
				ProductName = entity.ProductName,
				Description = entity.Description,
				Price = entity.Price,
				Tag = entity.Tag
			};
		}
	}
}
