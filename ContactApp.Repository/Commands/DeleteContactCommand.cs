// Authored By Yogesh, File Name : DeleteContactCommand.cs ,Date 18-07-2021

using MediatR;

namespace ContactApp.Repository.Commands
{
    /// <summary>
    /// Defines the <see cref="DeleteContactCommand" />.
    /// </summary>
    public sealed class DeleteContactCommand : IRequest<bool>
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public long Id { get; set; }
    }
}
