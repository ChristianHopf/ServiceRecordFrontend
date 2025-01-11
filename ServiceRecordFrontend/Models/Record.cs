using System.ComponentModel.DataAnnotations;

namespace ServiceRecordFrontend.Models
{
    public class Record
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Owner { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string VIN { get; set; }

        [Required]
        public string License { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public string Service { get; set; }

        [Required]
        public double Charge { get; set; }
    }
}
