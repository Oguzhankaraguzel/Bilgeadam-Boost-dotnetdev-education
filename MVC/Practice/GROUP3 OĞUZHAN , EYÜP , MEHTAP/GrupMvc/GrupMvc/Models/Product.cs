using GrupMvc.CustomeVal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrupMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool InStoct { get; set; }
        public int CatogoryId { get; set; }
        public virtual Catogory Catogory { get; set; }
        [NotMapped]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg" }, ErrorMessage = "Lütfen JPEG formatında bir dosya yükleyin.")]
        public IFormFile? PhotoData { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
