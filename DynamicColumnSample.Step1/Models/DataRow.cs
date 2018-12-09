using System.Collections.Generic;
using Prism.Mvvm;

namespace DynamicColumnSample.Step1.Models
{
    /// <summary>
    ///     DataRow
    /// </summary>
    public class CustomDataRow : BindableBase
    {
        private IList<CustomDataColumn> _customDataColumns;
        public string Id { get; set; }

        public IList<CustomDataColumn> CustomDataColumns
        {
            get => _customDataColumns;
            set => SetProperty(ref _customDataColumns, value);
        }
    }
}