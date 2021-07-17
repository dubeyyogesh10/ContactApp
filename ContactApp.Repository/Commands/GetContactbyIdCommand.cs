// Authored By Yogesh, File Name : GetContactbyIdCommand.cs ,Date 18-07-2021

namespace ContactApp.Repository.Commands
{
    using ContactApp.Infra.Model;
    using MediatR;

    /// <summary>
    /// Defines the <see cref="GetContactbyIdCommand" />.
    /// </summary>
    public sealed class GetContactbyIdCommand : IRequest<Contact>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string id { get; set; }
    }
}
