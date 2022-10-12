namespace LearnMapster.Models.DTOs
{
    public class PersonShortInfoDto
    {
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public List<Address> Addresses { get; set; }
    }
    public class PersonShortInfoWithAddress
    {
        public string? FullName { get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
