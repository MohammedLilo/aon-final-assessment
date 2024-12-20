using aon_final_assessment.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace aon_final_assessment.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public DateTime? ProductionDate { get; set; }
        [AllowNull]
        public DateTime? ExpirationDate { get; set; }
        public Product() { }
        private Product(ProductInputDTO productInputDTO)
        {
            Name = productInputDTO.Name;
            Description = productInputDTO.Description;
            Price = productInputDTO.Price;
            ProductionDate = productInputDTO.ProductionDate;
            ExpirationDate = productInputDTO.ExpirationDate;
        }
        public static Product FromProductInputDTO(ProductInputDTO productInputDTO)
        {
            return new Product(productInputDTO);
        }
    }
}
