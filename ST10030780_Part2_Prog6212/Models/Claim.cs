// Models/Claim.cs
using System;

namespace ST10030780_Part2_Prog6212.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string SupportingDocumentPath { get; set; }
    }
}
