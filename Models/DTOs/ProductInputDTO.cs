using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace aon_final_assessment.Models.DTOs
{
    public class ProductInputDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0.01, int.MaxValue, ErrorMessage = $"price value must be between 0.01 and 214748364")]
        public decimal Price { get; set; }
        [Required]
        public DateTime? ProductionDate { get; set; }
        [AllowNull]
        public DateTime? ExpirationDate { get; set; }
    }
}
