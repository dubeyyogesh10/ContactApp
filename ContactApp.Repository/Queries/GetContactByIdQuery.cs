// Authored By Yogesh, File Name : GetContactByIdQuery.cs ,Date 18-07-2021

namespace ContactApp.Repository.Queries
{
    using ContactApp.Infra.Model;
    using MediatR;

    /// <summary>
    /// Defines the <see cref="GetContactByIdQuery" />.
    /// </summary>
    public sealed class GetContactByIdQuery : IRequest<Contact>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }
    }
}
