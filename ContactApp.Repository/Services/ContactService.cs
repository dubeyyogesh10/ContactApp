// Authored By ContactService.cs, Date 17-07-2021

namespace ContactApp.Repository.Services
{
    using ContactApp.Infra.Database;
    using ContactApp.Infra.Model;
    using ContactApp.Repository.Services.Interface;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="ContactService" />.
    /// </summary>
    public sealed class ContactService : IContactService
    {
        /// <summary>
        /// Defines the dbClient.
        /// </summary>
        private readonly IDbClient dbClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactService"/> class.
        /// </summary>
        /// <param name="dbClient">The dbClient<see cref="IDbClient"/>.</param>
        public ContactService(IDbClient dbClient)
        {
            this.dbClient = dbClient;
        }

        /// <summary>
        /// The AddContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> AddContact(Contact contact)
        {
            return await dbClient.AddContact(contact).ConfigureAwait(false);
        }

        /// <summary>
        /// The DeleteContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> DeleteContact(long id)
        {
            return await dbClient.DeleteContact(id).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public async Task<Contact> GetContact(long id)
        {
            return await dbClient.GetContact(id).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetContacts.
        /// </summary>
        /// <returns>The <see cref="Task{List{Contact}}"/>.</returns>
        public async Task<List<Contact>> GetContacts()
        {
            return await dbClient.GetContacts().ConfigureAwait(false);
        }

        /// <summary>
        /// The UpdateContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> UpdateContact(Contact contact)
        {
            return await dbClient.UpdateContact(contact).ConfigureAwait(false);
        }
    }
}
