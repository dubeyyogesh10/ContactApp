// Authored By Yogesh, File Name : GetAllContactsHandler.cs ,Date 18-07-2021

namespace ContactApp.Repository.Handlers
{
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Commands;
    using MediatR;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="GetAllContactsHandler" />.
    /// </summary>
    internal sealed class GetAllContactsHandler : IRequestHandler<GetAllContactCommand, List<Contact>>
    {
        /// <summary>
        /// The Handle.
        /// </summary>
        /// <param name="request">The request<see cref="GetAllContactCommand"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{List{Contact}}"/>.</returns>
        public Task<List<Contact>> Handle(GetAllContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
