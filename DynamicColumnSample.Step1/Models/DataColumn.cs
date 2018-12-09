using Prism.Mvvm;

namespace DynamicColumnSample.Step1.Models
{
    /// <summary>
    /// DataColumn
    /// </summary>
    public class CustomDataColumn : BindableBase
    {
        private string _headerText;
        private object _value;
        public int Index { get; set; }

        public string HeaderText
        {
            get => _headerText;
            set => SetProperty(ref _headerText, value);
        }

        public object Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}