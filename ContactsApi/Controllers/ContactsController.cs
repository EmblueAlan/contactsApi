using ContactsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {


        private readonly ILogger<ContactsController> _logger;

        public ContactsController(ILogger<ContactsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("PostContactsCsv")]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]

        public IEnumerable<ContactListResponseDto> PostContactsCsv([FromForm] ContactListRequestDto contactListRequest)
        {
            //esto devuelve el contenido del csv
            if (contactListRequest.ContractCsv!=null)
            {
                contactListRequest.ContractCsv.OpenReadStream();
                
            }


            //aca devolveriamos los contactos ya procesados
            var clr = new List<ContactListResponseDto>();
            clr.Add(new ContactListResponseDto { ContactId = 123, ContactMail = "asda@asd.com", Motive = "asd", State = "as" });

            return clr;
           
        }
    }
}