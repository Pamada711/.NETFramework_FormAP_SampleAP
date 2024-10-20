using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;

namespace TestApp.Domain.Repositories
{
    public interface IHistoryListRepository
    {
        IReadOnlyList<HistoryDataEntity> GetErrorDataListByErrorCode(string Id);
    }
}
