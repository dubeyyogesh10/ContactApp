// Authored By Yogesh, File Name : AddContactHandler.cs ,Date 18-07-2021

namespace ContactApp.Repository.Handlers
{
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Commands;
    using MediatR;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="AddContactHandler" />.
    /// </summary>
    internal class AddContactHandler : IRequestHandler<AddContactCommand, Contact>
    {
        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="request">The request<see cref="AddContactCommand"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public Task<Contact> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
