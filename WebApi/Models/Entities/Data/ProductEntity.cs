using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities.Data
{
    public class ProductEntity
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;

        [Column(TypeName = "nvarchar(200)")]
        public string ProductName { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
