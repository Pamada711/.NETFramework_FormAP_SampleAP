using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain.Entities
{
    public sealed class ErrorDataEntity
    {
        public ErrorDataEntity(
            string id, 
            string name, 
            string content, 
            string errorCode)
        {
            Id = id;
            Name = name;
            Content = content;
            ErrorCode = errorCode;
        }

        public string Id { get; }
        public string Name { get; }
        public string Content { get; }
        public string ErrorCode { get; }

    }
}
