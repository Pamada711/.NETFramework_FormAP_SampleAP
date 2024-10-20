using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;
using TestApp.Domain.Repositories;

namespace TestApp.Infrastracture
{
    public class HistoryDataSQL : IHistoryListRepository
    {
        public IReadOnlyList<HistoryDataEntity> GetErrorDataListByErrorCode(string Id)
        {
            List<HistoryDataEntity> result = new List<HistoryDataEntity>();

            if (Id == "1")
            {
                result.Add(new HistoryDataEntity("1", 1, "taro", "aaaa", "E0001"));
                result.Add(new HistoryDataEntity("1", 2, "taro", "aaaa", "E0001"));
                result.Add(new HistoryDataEntity("1", 3, "taro", "aaaa", "E0001"));
            }
            else if (Id == "2")
            {
                result.Add(new HistoryDataEntity("2", 1, "kenta", "bbbb", "E0002"));
                result.Add(new HistoryDataEntity("2", 2, "kenta", "bbbb", "E0002"));
            }

            return result;
        }
    }
}
