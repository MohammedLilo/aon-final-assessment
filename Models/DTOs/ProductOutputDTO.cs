using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace aon_final_assessment.Models.DTOs
{
    public class ProductOutputDTO

    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        private ProductOutputDTO(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            ProductionDate = product.ProductionDate;
            ExpirationDate = product.ExpirationDate;
        }
        public static ProductOutputDTO FromProduct(Product product) => new ProductOutputDTO(product);
    }

}
