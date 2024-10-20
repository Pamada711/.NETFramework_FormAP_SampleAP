using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;
using TestApp.Domain.Repositories;

namespace TestApp.Infrastracture
{
    public class ErrorDataSQL : IErrorListRepository
    {
        public IReadOnlyList<ErrorDataEntity> GetErrorDataList(int Id)
        {
            var result = new List<ErrorDataEntity>();

            if (Id == 1)
            {
                result.Add(new ErrorDataEntity("1", "taro", "aaaa", "E0001"));
                result.Add(new ErrorDataEntity("1", "taro_2", "aaaa_2", "E0002"));
            }
            else if (Id == 2)
            {
                result.Add(new ErrorDataEntity("2", "kenta", "bbbb", "E0002"));
            }
            else if (Id == 3)
            {
                result.Add(new ErrorDataEntity("3", "eri", "cccc", "E0003"));
            }
            else if (Id == 4)
            {
                result.Add(new ErrorDataEntity("4", "mitio", "dddd", "E0004"));
            }

            return result;

        }

        public IReadOnlyList<ErrorDataEntity> GetErrorDataListByErrorCode(string ErrorCode)
        {
            var result = new List<ErrorDataEntity>();

            if (ErrorCode == "E0001")
            {
                result.Add(new ErrorDataEntity("1", "taro", "aaaa", "E0001"));
                result.Add(new ErrorDataEntity("1", "taro_2", "aaaa_2", "E0002"));

            }
            else if (ErrorCode == "E0002")
            {
                result.Add(new ErrorDataEntity("2", "kenta", "bbbb", "E0002"));
            }

            return result;
        }
    }
}
