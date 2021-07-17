// Authored By IContactService.cs, Date 17-07-2021

namespace ContactApp.Repository.Services.Interface
{
    using ContactApp.Infra.Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IContactService" />.
    /// </summary>
    public interface IContactService
    {
        /// <summary>
        /// The GetContacts.
        /// </summary>
        /// <returns>The <see cref="List{Contact}"/>.</returns>
        Task<List<Contact>> GetContacts();

        /// <summary>
        /// The AddContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> AddContact(Contact contact);

        /// <summary>
        /// The GetContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Contact GetContact(string id);

        /// <summary>
        /// The DeleteContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> DeleteContact(string id);

        /// <summary>
        /// The UpdateContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> UpdateContact(string id);
    }
}
