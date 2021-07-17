using ContactApp.Infra.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Infra.Database
{
    public interface IDbClient
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
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<Contact> GetContact(long id);

        /// <summary>
        /// The DeleteContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> DeleteContact(long id);

        /// <summary>
        /// The UpdateContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        Task<bool> UpdateContact(Contact contact);
    }
}
