using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using TestApp.Domain.BindHelpers;
using TestApp.Domain.Entities;
using TestApp.Domain.Helpers;
using TestApp.Domain.Repositories;
using TestApp.Infrastracture;

namespace TestApp.ViewModels
{
    public class ErrorListViewModel : ViewModelBase
    {
        private IErrorListRepository _errorList;
        private IDialogService _dialogService;
        private IDialogModelessService _dialogModelessService;

        public ErrorListViewModel()
            : this(new ErrorDataSQL(), 
                  new DialogService(),
                  new DialogModelessService())
        {
        }

        public ErrorListViewModel(
            IErrorListRepository errorList,
            IDialogService dialogService,
            IDialogModelessService dialogModelessService)
        {
            _errorList = errorList;
            _dialogService = dialogService;
            _dialogModelessService = dialogModelessService;
        }

        private string _idTextBoxText = string.Empty;
        public string IdText
        {
            get
            {
                return _idTextBoxText;
            }
            set
            {
                SetProperty(ref _idTextBoxText, value);
            }
        }

        public BindingList<ErrorListViewModelErrorList> ErrorDataList { get; set; }
            = new BindingList<ErrorListViewModelErrorList>();

        public BindingList<ErrorListViewModelSelectedItem> SelectedLists { get; set; }
            = new BindingList<ErrorListViewModelSelectedItem>();

        public void ErrorDataGridViewClick(ErrorListViewModelErrorList row)
        {

            SelectedLists.Clear();
            List<SelectedDataEntity> list = new List<SelectedDataEntity>();
            list.Add(new SelectedDataEntity(nameof(row.Id), row.Id));
            list.Add(new SelectedDataEntity(nameof(row.Name), row.Name));
            list.Add(new SelectedDataEntity(nameof(row.Content), row.Content));
            list.Add(new SelectedDataEntity(nameof(row.ErrorCode), row.ErrorCode));

            foreach(var entity in list)
            {
                SelectedLists.Add(new ErrorListViewModelSelectedItem(entity));
            }
        }

        public void SearchExecute()
        {
            ErrorDataList.Clear();
            Guard.IsNull(IdText, "IDを入力してください");
            var id = Guard.IsNumber(IdText, "数字を入力してください");

            foreach(var entity in _errorList.GetErrorDataList(id))
            {
                ErrorDataList.Add(new ErrorListViewModelErrorList(entity));
            }
        }

        public void HistoryReferenceShowExecute()
        {
            var vm = new HistoryReferenceViewModel();
            _dialogModelessService.Show(vm);
        }

        internal void ErrorAggregationShowExecute()
        {
            var vm = new ErrorAggregationViewModel();
            _dialogService.ShowDialog(vm);
        }
    }
}