using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestApp.Domain.Entities;
using TestApp.Domain.Helpers;
using TestApp.Domain.Repositories;
using TestApp.Infrastracture;

namespace TestApp.ViewModels
{
    public class HistoryReferenceViewModel : ViewModelBase
    {
        private IErrorListRepository _errorList;
        private IHistoryListRepository _historyList;


        public HistoryReferenceViewModel()
            : this(new ErrorDataSQL(), new HistoryDataSQL())
        {
        }

        public HistoryReferenceViewModel(
            IErrorListRepository errorList,
            IHistoryListRepository historyList)
        {
            _errorList = errorList;
            _historyList = historyList;
        }

        private string _errorCodeTextBoxText = string.Empty;
        public string ErrorCodeTextBoxText
        {
            get
            {
                return _errorCodeTextBoxText;
            }
            set
            {
                SetProperty(ref _errorCodeTextBoxText, value);
            }
        }


        public BindingList<HistoryReferenceViewModelErrorList> ErrorDataList { get; set; }
            = new BindingList<HistoryReferenceViewModelErrorList>();

        public BindingList<HistoryReferenceViewModelHistoryList> HistoryDataList { get; set; }
            = new BindingList<HistoryReferenceViewModelHistoryList>();

        public void SearchExecute()
        {
            ErrorDataList.Clear();
            Guard.IsNull(ErrorCodeTextBoxText, "エラーコードを入力してください");
            Guard.IsOnlyAlphaNumeric(ErrorCodeTextBoxText, "半角英数字で入力してください");

            foreach(var entity in _errorList.GetErrorDataListByErrorCode(ErrorCodeTextBoxText))
            {
                ErrorDataList.Add(new HistoryReferenceViewModelErrorList(entity));
            }
        }

        public void ErrorDataGridViewClick(HistoryReferenceViewModelErrorList row)
        {
            HistoryDataList.Clear();
            foreach (var entity in _historyList.GetErrorDataListByErrorCode(row.Id))
            {
                HistoryDataList.Add(new HistoryReferenceViewModelHistoryList(entity));
            }
        }
    }
}