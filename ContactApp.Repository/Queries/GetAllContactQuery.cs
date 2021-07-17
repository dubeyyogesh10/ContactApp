// Authored By Yogesh, File Name : GetAllContactQuery.cs ,Date 18-07-2021

namespace ContactApp.Repository.Queries
{
    using ContactApp.Infra.Model;
    using MediatR;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="GetAllContactQuery" />.
    /// </summary>
    public sealed class GetAllContactQuery : IRequest<List<Contact>>
    {
    }
}
