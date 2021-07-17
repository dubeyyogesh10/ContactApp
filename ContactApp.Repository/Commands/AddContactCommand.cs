// Authored By Yogesh, File Name : AddContactCommand.cs ,Date 18-07-2021

namespace ContactApp.Repository.Commands
{
    using ContactApp.Infra.Model;
    using MediatR;
    using System;

    /// <summary>
    /// Defines the <see cref="AddContactCommand" />.
    /// </summary>
    public sealed class AddContactCommand : IRequest<Contact>
    {
        /// <summary>
        /// Gets or sets the PhoneNumber.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Guid Id { get; set; }

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
