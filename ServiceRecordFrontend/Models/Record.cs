using System.ComponentModel.DataAnnotations;

namespace ServiceRecordFrontend.Models
{
    public class Record
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Owner { get; set; }

        [Required]
        public required DateTime Date { get; set; }

        [Required]
        public required string Make { get; set; }

        [Required]
        public required string Model { get; set; }

        [Required]
        public required int Year { get; set; }

        [Required]
        public required string VIN { get; set; }

        [Required]
        public required string License { get; set; }

        [Required]
        public required int Mileage { get; set; }

        [Required]
        public required string Service { get; set; }

        [Required]
        public required double Charge { get; set; }
    }
}
