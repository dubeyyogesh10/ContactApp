// Authored By Yogesh, File Name : AddContactHandler.cs ,Date 18-07-2021

namespace ContactApp.Repository.Handlers
{
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Commands;
    using ContactApp.Repository.Services.Interface;
    using MediatR;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="AddContactHandler" />.
    /// </summary>
    internal class AddContactHandler : IRequestHandler<AddContactCommand, bool>
    {
        /// <summary>
        /// Defines the contactService.
        /// </summary>
        private readonly IContactService contactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactsHandler"/> class.
        /// </summary>
        /// <param name="contactService">The contactService<see cref="IContactService"/>.</param>
        public AddContactHandler(IContactService contactService)
        {
            this.contactService = contactService;
        }
        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="request">The request<see cref="AddContactCommand"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public async Task<bool> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            return await contactService.AddContact(new Contact
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Status = request.Status
            }).ConfigureAwait(false);
        }
    }
}
