using TestApp.Domain.Entities;

namespace TestApp.ViewModels
{
    public sealed class ErrorListViewModelErrorList
    {
        private ErrorDataEntity _entity;

        public ErrorListViewModelErrorList(ErrorDataEntity entity)
        {
            _entity = entity;
        }

        public string Id => _entity.Id;
        public string Name => _entity.Name;
        public string Content => _entity.Content;
        public string ErrorCode => _entity.ErrorCode;


    }
}