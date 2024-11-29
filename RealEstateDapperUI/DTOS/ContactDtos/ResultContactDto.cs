namespace RealEstateDapperUI.DTOS.ContactDtos
{
    public class ResultContactDto
    {
        public int ContactId {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Subject { get;set; }
        public string Email { get; set; }
        public string Message {  get; set; }
        public DateTime SendDate { get;set; }
    }
}
