using ContactApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactAppController : ControllerBase
    {

        private static Contact contact;
        private static List<Contact> contacts = new List<Contact>();

        //public ContactAppController()
        //{
        //    this.contacts = new List<Contact>();
        //}
        public Contact Contact
        {
            get => contact;
            set => contact = value;
        }
        public List<Contact> Contacts
        {
            get => contacts;
            set => contacts = value;
        }

        // GET: api/<ContactAppController>
        [HttpGet]
        public ActionResult<List<Contact>> GetContacts()
        {
            return Ok(Contacts);
        }

        // GET api/<ContactAppController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> GetContactById(Guid id)
        {
            return Contacts.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<ContactAppController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Contact value)
        {
            var contact = new Contact();
            if (contact != null)
            {
                contact.FirstName = value.FirstName;
                contact.LastName = value.LastName;
                contact.Email = value.Email;
                contact.PhoneNumer = value.PhoneNumer;
                contact.Status = value.Status;
            }
            this.Contacts.Add(contact);
            return Ok(true);
        }

        // PUT api/<ContactAppController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(Guid id, [FromBody] Contact value)
        {
            var contact = Contacts.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            {
                contact.Id = value.Id;
                contact.FirstName = value.FirstName;
                contact.LastName = value.LastName;
                contact.Email = value.Email;
                contact.PhoneNumer = value.PhoneNumer;
                contact.Status = value.Status;
            }
            return Ok(true);
        }

        // DELETE api/<ContactAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
