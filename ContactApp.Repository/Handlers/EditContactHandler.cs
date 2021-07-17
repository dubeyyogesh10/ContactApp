using ContactApp.Infra.Model;
using ContactApp.Repository.Commands;
using ContactApp.Repository.Services.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactApp.Repository.Handlers
{
    class EditContactHandler : IRequestHandler<EditContactCommand, bool>
    {
        /// <summary>
        /// Defines the contactService.
        /// </summary>
        private readonly IContactService contactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditContactHandler"/> class.
        /// </summary>
        /// <param name="contactService">The contactService<see cref="IContactService"/>.</param>
        public EditContactHandler(IContactService contactService)
        {
            this.contactService = contactService;
        }
        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public async Task<bool> Handle(EditContactCommand request, CancellationToken cancellationToken)
        {
            return await contactService.UpdateContact(new Contact
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Status = request.Status,
                Id = request.Id
            }).ConfigureAwait(false);
        }
    }
}
