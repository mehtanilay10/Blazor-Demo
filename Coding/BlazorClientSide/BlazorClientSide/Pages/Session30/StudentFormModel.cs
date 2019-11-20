using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorClientSide.Pages.Session30
{
    public class StudentFormModel
    {
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(5, 20)]
        public int Age { get; set; }

        [Required]
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Hey {FullName}, You are from {Country} and your Date of Birth is {DateOfBirth.ToShortDateString()}";
        }
    }
}
