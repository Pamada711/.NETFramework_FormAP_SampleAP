using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.ViewModels;

namespace TestApp.Domain.BindHelpers
{
    public sealed class DialogModelessService : IDialogModelessService
    {
        public void Show(ViewModelBase vm)
        {
            string viewName = vm.GetType().FullName.Replace("ViewModel", "View");
            Type type = Type.GetType(viewName);
            var view = (Form)Activator.CreateInstance(type, vm);
            view.Show();
            

        }
    }
}
