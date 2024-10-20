using System.Collections.Generic;
using TestApp.Domain.Entities;

namespace TestApp.Domain.Repositories
{
    public interface IErrorListRepository
    {
        IReadOnlyList<ErrorDataEntity> GetErrorDataList(int Id);
        IReadOnlyList<ErrorDataEntity> GetErrorDataListByErrorCode(string ErrorCode);
    }
}