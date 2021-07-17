using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp.Infra.Database.Config
{
    public sealed class DbConfig
    {
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
    }
}
