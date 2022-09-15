using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fake_ctrip.API.Models
{
    public class TouristRouteDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        // 计算方式：原价 * 折扣
        public decimal Price { get; set; }
        [Range(0.0, 1.0)]
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        [MaxLength]
        public string Features { get; set; }
        [MaxLength]
        public string Fees { get; set; }
        [MaxLength]
        public string Notes { get; set; }
        public ICollection<TouristRoutePictureDto> TouristRoutePictures { get; set; } = new List<TouristRoutePictureDto>();
        public double? Rating { get; set; }
        public string? TravelDays { get; set; }
        public string? TripType { get; set; }
        public string? DepartureCity { get; set; }
    }
}
