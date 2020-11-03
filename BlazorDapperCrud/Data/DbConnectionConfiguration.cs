using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public class DbConnectionConfiguration
    {
        public string Value { get; }
        public DbConnectionConfiguration(string value) => Value = value;
    }
}
