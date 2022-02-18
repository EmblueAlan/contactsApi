namespace ContactsApi.Models
{
    public class ContactListRequestDto
    {
        public int ContractId { get; set; }
        public IFormFile? ContractCsv { get; set; }
        public char ActionType { get; set; }
        public bool IsBigComplainer { get; set; }

    }
}
