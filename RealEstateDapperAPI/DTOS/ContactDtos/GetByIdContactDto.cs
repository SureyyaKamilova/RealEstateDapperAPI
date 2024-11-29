namespace RealEstateDapperAPI.DTOS.ContactDtos
{
    public class GetByIdContactDto
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; } = string.Empty;
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
