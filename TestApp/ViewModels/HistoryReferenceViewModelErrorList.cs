using TestApp.Domain.Entities;

namespace TestApp.ViewModels
{
    public sealed class HistoryReferenceViewModelErrorList
    {
        private ErrorDataEntity _entity;

        public HistoryReferenceViewModelErrorList(ErrorDataEntity entity)
        {
            _entity = entity;
        }
        public string Id => _entity.Id;
        public string Name => _entity.Name;
        public string Content => _entity.Content;
        public string ErrorCode => _entity.ErrorCode;
    }
}