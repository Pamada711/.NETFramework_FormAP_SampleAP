using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.ViewModels;

namespace TestApp.Domain.BindHelpers
{
    public interface IDialogModelessService
    {
        void Show(ViewModelBase vm);
    }
}
