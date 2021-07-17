// Authored By Yogesh, File Name : GetAllContactsHandler.cs ,Date 18-07-2021

namespace ContactApp.Repository.Handlers
{
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Queries;
    using ContactApp.Repository.Services.Interface;
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="GetAllContactsHandler" />.
    /// </summary>
    internal sealed class GetAllContactsHandler : IRequestHandler<GetAllContactQuery, List<Contact>>
    {
        /// <summary>
        /// Defines the contactService.
        /// </summary>
        private readonly IContactService contactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllContactsHandler"/> class.
        /// </summary>
        /// <param name="contactService">The contactService<see cref="IContactService"/>.</param>
        public GetAllContactsHandler(IContactService contactService)
        {
            this.contactService = contactService;
        }

        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="request">The request<see cref="GetAllContactCommand"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{Contact}}"/>.</returns>
        public async Task<List<Contact>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            return await contactService.GetContacts().ConfigureAwait(false);
        }
    }
}
