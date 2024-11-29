namespace RealEstateDapperUI.DTOS.ContactDtos
{
    public class CreateContactDto
    {
        public string ContactName { get; set; } 
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
