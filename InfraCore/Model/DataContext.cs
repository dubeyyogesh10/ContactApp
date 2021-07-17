// Authored By Yogesh, File Name : DataContext.cs ,Date 18-07-2021

namespace ContactApp.Infra.Model
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="DataContext" />.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions"/>.</param>
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Contact.
        /// </summary>
        public DbSet<Contact> Contact { get; set; }
    }
}
