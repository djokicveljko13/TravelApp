using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Range(1,100)]
        [Display(Name="Price per night")]
        public double Price { get; set; }   

        public int SquareMeters { get; set; }
        public int Occupancy { get; set; } //zauzetost
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Display(Name="Image url")]
        public string? ImageUrl { get; set; }
    }
}
