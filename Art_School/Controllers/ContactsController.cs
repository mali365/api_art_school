using Microsoft.AspNetCore.Mvc;
using Art_School.Models;

namespace Art_School.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private static readonly IReadOnlyList<Contact> Contacts =
        Array.Empty<Contact>();

    [HttpGet]
    public ActionResult<IReadOnlyList<Contact>> GetContacts()
    {
        return Ok(Contacts);
    }
}
