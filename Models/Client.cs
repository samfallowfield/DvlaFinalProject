namespace DvlaProject.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DrivingLicenseNumber { get; set; }
        public string? PostCode { get; set; }
        public string? EmailAddress { get; set; }
        public string? AppointmentDate { get; set; }
        public string? AppointmentTime { get; set; }
        public string? AppointmentLocation { get; set; } 
    }
}