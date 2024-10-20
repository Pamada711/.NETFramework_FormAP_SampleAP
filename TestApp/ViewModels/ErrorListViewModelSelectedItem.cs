using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Domain.Entities;

namespace TestApp.ViewModels
{
    public sealed class ErrorListViewModelSelectedItem
    {
        private SelectedDataEntity _entity;

        public ErrorListViewModelSelectedItem(SelectedDataEntity entity)
        {
            _entity = entity;
        }

        public string Key => _entity.Key;
        public string Value => _entity.Value;
    }
}
