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
    public partial class ErrorAggregationView : Form
    {
        private ErrorAggregationViewModel _viewModel;
        public ErrorAggregationView(ErrorAggregationViewModel viewModel)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _viewModel = viewModel;

        }
    }
}
