// Authored By Contact.cs, Date 16-07-2021

namespace ContactApp.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="Contact" />.
    /// </summary>
    public class Contact
    {
        public Contact()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the PhoneNumer.
        /// </summary>
        [Required]
        public string PhoneNumer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Status.
        /// </summary>
        public bool Status { get; set; }
    }
}
