using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DynamicColumnSample.Step1.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace DynamicColumnSample.Step1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IList<CustomDataRow> _sampleRows;

        public MainWindowViewModel()
        {
            Init();
        }

        public ICommand LoadedCommand { get; set; }

        private void Init()
        {
            LoadedCommand = new DelegateCommand(ExecuteLoadedCommand);
        }

        private void ExecuteLoadedCommand()
        {
            SampleRows = new List<CustomDataRow>
            {
                new CustomDataRow
                {
                    CustomDataColumns = new List<CustomDataColumn>
                    {
                        new CustomDataColumn { Index = 0, HeaderText = "HeaderText0", Value = "Value0" },
                        new CustomDataColumn { Index = 1, HeaderText = "HeaderText1", Value = "Value1" },
                        new CustomDataColumn { Index = 2, HeaderText = "HeaderText2", Value = "Value2" },
                        new CustomDataColumn { Index = 3, HeaderText = "HeaderText3", Value = "Value3" },
                        new CustomDataColumn { Index = 4, HeaderText = "HeaderText4", Value = "Value4" },
                        new CustomDataColumn { Index = 5, HeaderText = "HeaderText5", Value = "Value5" },
                        new CustomDataColumn { Index = 6, HeaderText = "HeaderText6", Value = "Value6" },
                        new CustomDataColumn { Index = 7, HeaderText = "HeaderText7", Value = "Value7" },
                        new CustomDataColumn { Index = 8, HeaderText = "HeaderText8", Value = "Value8" },
                        new CustomDataColumn { Index = 9, HeaderText = "HeaderText9", Value = "Value9" },
                    }
                },
                new CustomDataRow
                {
                    CustomDataColumns = new List<CustomDataColumn>
                    {
                        new CustomDataColumn { Index = 0, HeaderText = "HeaderText10", Value = "Value10" },
                        new CustomDataColumn { Index = 1, HeaderText = "HeaderText11", Value = "Value11" },
                        new CustomDataColumn { Index = 2, HeaderText = "HeaderText12", Value = "Value12" },
                        new CustomDataColumn { Index = 3, HeaderText = "HeaderText13", Value = "Value13" },
                        new CustomDataColumn { Index = 4, HeaderText = "HeaderText14", Value = "Value14" },
                        new CustomDataColumn { Index = 5, HeaderText = "HeaderText15", Value = "Value15" },
                        new CustomDataColumn { Index = 6, HeaderText = "HeaderText16", Value = "Value16" },
                        new CustomDataColumn { Index = 7, HeaderText = "HeaderText17", Value = "Value17" },
                        new CustomDataColumn { Index = 8, HeaderText = "HeaderText18", Value = "Value18" },
                        new CustomDataColumn { Index = 9, HeaderText = "HeaderText19", Value = "Value19" },
                    }
                },
                new CustomDataRow
                {
                    CustomDataColumns = new List<CustomDataColumn>
                    {
                        new CustomDataColumn { Index = 0, HeaderText = "HeaderText20", Value = "Value20" },
                        new CustomDataColumn { Index = 1, HeaderText = "HeaderText21", Value = "Value21" },
                        new CustomDataColumn { Index = 2, HeaderText = "HeaderText22", Value = "Value22" },
                        new CustomDataColumn { Index = 3, HeaderText = "HeaderText23", Value = "Value23" },
                        new CustomDataColumn { Index = 4, HeaderText = "HeaderText24", Value = "Value24" },
                        new CustomDataColumn { Index = 5, HeaderText = "HeaderText25", Value = "Value25" },
                        new CustomDataColumn { Index = 6, HeaderText = "HeaderText26", Value = "Value26" },
                        new CustomDataColumn { Index = 7, HeaderText = "HeaderText27", Value = "Value27" },
                        new CustomDataColumn { Index = 8, HeaderText = "HeaderText28", Value = "Value28" },
                        new CustomDataColumn { Index = 9, HeaderText = "HeaderText29", Value = "Value29" },
                    }
                },

            };

        }

        /// <summary>
        /// DataRows
        /// </summary>
        public IList<CustomDataRow> SampleRows
        {
            get => _sampleRows;
            set => SetProperty(ref _sampleRows ,value);
        }
    }
}
