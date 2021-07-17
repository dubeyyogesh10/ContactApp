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
        private readonly IDbClient dbClient;

        public ContactService(IDbClient dbClient)
        {
            this.dbClient = dbClient;
        }
        /// <summary>
        /// The AddContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The DeleteContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> DeleteContact(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public Contact GetContact(string id)
        {
            var test = new Contact
            {
                FirstName = "ABC",
                LastName = "demo",
                Email = "demo@demo.com",
                PhoneNumber = "123212212",
                Status = false
            };
            return test;
        }

        /// <summary>
        /// The GetContacts.
        /// </summary>
        /// <returns>The <see cref="Task{List{Contact}}"/>.</returns>
        public Task<List<Contact>> GetContacts()
        {
            return dbClient.GetContacts();
        }

        /// <summary>
        /// The UpdateContact.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public Task<bool> UpdateContact(string id)
        {
            throw new NotImplementedException();
        }
    }
}
