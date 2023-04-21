using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities.Data
{
    public class TagEntity
    {
        [Key]
        public int Id { get; set; }
        public string TagName { get; set; } = null!;

        public ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();
    }
}
