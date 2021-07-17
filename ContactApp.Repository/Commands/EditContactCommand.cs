// Authored By Yogesh, File Name : EditContactCommand.cs ,Date 18-07-2021

namespace ContactApp.Repository.Commands
{
    using MediatR;
    using System;

    /// <summary>
    /// Defines the <see cref="EditContactCommand" />.
    /// </summary>
    public sealed class EditContactCommand : IRequest<bool>
    {
        /// <summary>
        /// Gets or sets the PhoneNumber.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Status.
        /// </summary>
        public bool Status { get; set; }
    }
}
