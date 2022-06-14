using System.ComponentModel.DataAnnotations;

namespace BlazorAppTest
{
    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
    public class Starship
    {
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        public string Identifier { get; set; }

        public string Description { get; set; }

        [Required]
        public string Classification { get; set; }

        [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "This form disallows unapproved ships.")]
        public bool IsValidatedDesign { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
