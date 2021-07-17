
using ContactApp.Infra.Model;
using ContactApp.Repository.Commands;
using ContactApp.Repository.Queries;
using MediatR;
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
        private readonly IMediator mediatr;

        public ContactAppController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }

        // GET: api/<ContactAppController>
        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts()
        {
            return Ok(await mediatr.Send(new GetAllContactQuery()).ConfigureAwait(false));
        }

        // GET api/<ContactAppController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(long id)
        {
            return Ok(await mediatr.Send(new GetContactByIdQuery() { Id = id }).ConfigureAwait(false));
        }

        // POST api/<ContactAppController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Contact request)
        {
            return Ok(await mediatr.Send(new EditContactCommand()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Status = request.Status,
            }).ConfigureAwait(false));
        }

        // PUT api/<ContactAppController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdateContact(long id, [FromBody] Contact request)
        {
            return Ok(await mediatr.Send(new EditContactCommand()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Status = request.Status,
                Id = id
            }).ConfigureAwait(false));
        }

        // DELETE api/<ContactAppController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok(await mediatr.Send(new DeleteContactCommand() { Id = id }).ConfigureAwait(false));
        }
    }
}
