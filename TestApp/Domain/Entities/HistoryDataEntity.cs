using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Domain.Entities
{
    public sealed class HistoryDataEntity
    {
        public HistoryDataEntity(
            string id, 
            int historyNumber, 
            string name, 
            string content, 
            string errorCode)
        {
            Id = id;
            HistoryNumber = historyNumber;
            Name = name;
            Content = content;
            ErrorCode = errorCode;
        }

        public string Id { get; }
        public int HistoryNumber { get; }
        public string Name { get; }
        public string Content { get; }
        public string ErrorCode { get; }
    }
}
