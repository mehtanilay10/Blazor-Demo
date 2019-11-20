using System;

namespace BlazorClientSide.Pages.Session29
{
    public class StudentFormModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Hey {FullName}, You are from {Country} and your Date of Birth is {DateOfBirth.ToShortDateString()}";
        }
    }
}
