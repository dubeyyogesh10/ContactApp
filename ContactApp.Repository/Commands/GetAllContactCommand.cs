// Authored By Yogesh, File Name : GetAllContactCommand.cs ,Date 18-07-2021

namespace ContactApp.Repository.Commands
{
    using ContactApp.Infra.Model;
    using MediatR;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="GetAllContactCommand" />.
    /// </summary>
    public sealed class GetAllContactCommand : IRequest<List<Contact>>
    {
    }
}
