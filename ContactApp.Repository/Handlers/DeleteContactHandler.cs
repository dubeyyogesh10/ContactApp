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
    class DeleteContactHandler : IRequestHandler<DeleteContactCommand, bool>
    {
        /// <summary>
        /// Defines the contactService.
        /// </summary>
        private readonly IContactService contactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactsHandler"/> class.
        /// </summary>
        /// <param name="contactService">The contactService<see cref="IContactService"/>.</param>
        public DeleteContactHandler(IContactService contactService)
        {
            this.contactService = contactService;
        }

        public async Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            return await contactService.DeleteContact(request.Id).ConfigureAwait(false);
        }
    }
}
