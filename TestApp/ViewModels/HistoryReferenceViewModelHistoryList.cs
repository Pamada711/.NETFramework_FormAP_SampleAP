using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;

namespace TestApp.ViewModels
{
    public sealed class HistoryReferenceViewModelHistoryList
    {
        private HistoryDataEntity _entity;

        public HistoryReferenceViewModelHistoryList(HistoryDataEntity entity)
        {
            _entity = entity;
        }

        public string Id => _entity.Id;
        public int HistoryNumber => _entity.HistoryNumber;
        public string Name => _entity.Name;
        public string Content => _entity.Content;
        public string ErrorCode => _entity.ErrorCode;


    }
}
