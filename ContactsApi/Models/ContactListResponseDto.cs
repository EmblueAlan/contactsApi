namespace ContactsApi.Models
{
    public class ContactListResponseDto
    {
        public int ContactId { get; set; }
        public string? ContactMail { get; set; }
        public string? Motive {get;set;}
        public string? State { get; set; }

    }
}
