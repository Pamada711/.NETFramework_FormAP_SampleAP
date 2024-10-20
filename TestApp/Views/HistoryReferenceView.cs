using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.ViewModels;

namespace TestApp.Views
{
    public partial class HistoryReferenceView : Form
    {
        private HistoryReferenceViewModel _viewModel;
        public HistoryReferenceView(HistoryReferenceViewModel viewModel)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _viewModel = viewModel;

            this.ErrorCodeTextBox.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.ErrorCodeTextBoxText));

            ErrorDataGridView.DataSource = _viewModel.ErrorDataList;
            HistoryDataGridView.DataSource = _viewModel.HistoryDataList;

            SearchButton.Click += (sender, e) => _viewModel.SearchExecute();

            ErrorDataGridView.Click += (sender, e)
                => _viewModel.ErrorDataGridViewClick(
                    ErrorDataGridView.CurrentRow.DataBoundItem as HistoryReferenceViewModelErrorList);

        }


    }
}
