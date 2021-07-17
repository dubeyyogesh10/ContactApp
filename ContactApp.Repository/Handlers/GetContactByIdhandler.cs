// Authored By Yogesh, File Name : GetContactByIdhandler.cs ,Date 18-07-2021

namespace ContactApp.Repository.Handlers
{
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Queries;
    using ContactApp.Repository.Services.Interface;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="GetContactByIdhandler" />.
    /// </summary>
    internal sealed class GetContactByIdhandler : IRequestHandler<GetContactByIdQuery, Contact>
    {
        /// <summary>
        /// Defines the contactService.
        /// </summary>
        private readonly IContactService contactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactByIdhandler"/> class.
        /// </summary>
        /// <param name="contactService">The contactService<see cref="IContactService"/>.</param>
        public GetContactByIdhandler(IContactService contactService)
        {
            this.contactService = contactService;
        }

        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="request">The request<see cref="GetContactByIdQuery"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public async Task<Contact> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            return await contactService.GetContact(request.Id).ConfigureAwait(false);
        }
    }
}
