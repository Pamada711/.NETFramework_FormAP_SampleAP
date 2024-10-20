using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain.Entities
{
    public sealed class SelectedDataEntity
    {
        public SelectedDataEntity(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; }
        public string Value { get; }
    }
}
