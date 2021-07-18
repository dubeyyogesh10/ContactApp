// Authored By Yogesh, File Name : DbClient.cs ,Date 18-07-2021

namespace ContactApp.Infra.Database
{
    using ContactApp.Infra.Model;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="DbClient" />.
    /// </summary>
    public sealed class DbClient : IDbClient
    {
        /// <summary>
        /// Defines the context.
        /// </summary>
        private readonly DataContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DbClient"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="DataContext"/>.</param>
        public DbClient(DataContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// The AddContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> AddContact(Contact contact)
        {
            await context.Contact.AddAsync(contact);
            var result = await context.SaveChangesAsync().ConfigureAwait(false);
            return result > 0;
        }

        /// <summary>
        /// The DeleteContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> DeleteContact(long id)
        {
            var contact = await context.Contact.FindAsync(id).ConfigureAwait(false);
            if (contact != null)
            {
                context.Contact.Remove(contact);
                var result = await context.SaveChangesAsync().ConfigureAwait(false);
                return result > 0;
            }

            return false;
        }

        /// <summary>
        /// The GetContact.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="Task{Contact}"/>.</returns>
        public async Task<Contact> GetContact(long id)
        {
            return await context.Contact.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// The GetContacts.
        /// </summary>
        /// <returns>The <see cref="List{Contact}"/>.</returns>
        public async Task<List<Contact>> GetContacts()
        {
            return await context.Contact.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// The UpdateContact.
        /// </summary>
        /// <param name="contact">The contact<see cref="Contact"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> UpdateContact(Contact request)
        {
            var existingContact = await context.Contact.FindAsync(request.Id).ConfigureAwait(false);
            if (existingContact != null)
            {
                existingContact.FirstName = request.FirstName;
                existingContact.LastName = request.LastName;
                existingContact.Email = request.Email;
                existingContact.PhoneNumber = request.PhoneNumber;
                existingContact.Status = request.Status;
                context.Contact.Update(existingContact);
                var result = await context.SaveChangesAsync().ConfigureAwait(false);
                return result > 0;
            }

            return false;
        }
    }
}
