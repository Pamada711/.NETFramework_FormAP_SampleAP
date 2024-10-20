using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Infrastracture;
using TestApp.ViewModels;


namespace TestApp.Views
{
    public partial class ErrorListView : Form
    {
        private ErrorListViewModel _viewModel
            = new ErrorListViewModel();

        public ErrorListView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.IdTextBox.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.IdText));
            /*
            this.ErrorDataGridView.DataBindings.Add(
                "DataSource", _viewModel, nameof(_viewModel.ErrorLists));
            */
            ErrorDataGridView.DataSource = _viewModel.ErrorDataList;
            ErrorDataGridView.Columns[nameof(ErrorListViewModelErrorList.Id)].HeaderText = "ID";
            ErrorDataGridView.Columns[nameof(ErrorListViewModelErrorList.Name)].HeaderText = "名前";
            ErrorDataGridView.Columns[nameof(ErrorListViewModelErrorList.Content)].HeaderText = "コンテンツ";
            ErrorDataGridView.Columns[nameof(ErrorListViewModelErrorList.ErrorCode)].HeaderText = "エラーコード";
            ErrorDataGridView.Columns[nameof(ErrorListViewModelErrorList.Content)].Width = 150;
            /*
            ErrorDataGridView.SelectionChanged += (sender, e)
                => _viewModel.ErrorDataGridSelectedItem = ErrorDataGridView.CurrentRow.DataBoundItem as ErrorListViewModelErrorList;
            */
            
            ErrorDataGridView.Click += (sender, e)
                => _viewModel.ErrorDataGridViewClick(
                    ErrorDataGridView.CurrentRow.DataBoundItem as ErrorListViewModelErrorList);

            SelectedItemDataGrid.DataSource = _viewModel.SelectedLists;
            
            SearchErrorListButton.Click += (sender, e) => _viewModel.SearchExecute();

            MenuItemHistoriyReferenceLink.Click += (sender, e) => _viewModel.HistoryReferenceShowExecute();
            MenuItemErrorAggregationLink.Click += (sender, e) => _viewModel.ErrorAggregationShowExecute();


        }



    }
}
