using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interactivity;
using DynamicColumnSample.Step1.Models;

namespace DynamicColumnSample.Step1.Behaviors
{
    public class DataGridBehavior : Behavior<DataGrid>
    {
        public DataGridBehavior()
        {

        }

        private void OnSetItemsSource()
        {
            if (!(ItemsSource is IList<CustomDataRow> list)) return;
            if (!(AssociatedObject is DataGrid dataGrid)) return;

            var idx = 0;
            var firstRow = list.First();
            foreach (var column in firstRow.CustomDataColumns)
            {
                dataGrid.Columns.Add(new DataGridTextColumn
                {
                    Binding = new Binding($"CustomDataColumns[{column.Index}].Value"),
                    Header = column.HeaderText
                });
                idx++;
            }

            dataGrid.ItemsSource = list;
        }

        private void OnUnsetItemsSource()
        {
            if (!(AssociatedObject is DataGrid dataGrid)) return;
            dataGrid.Columns.Clear();
        }


        protected override void OnAttached()
        {
            if (!(AssociatedObject is DataGrid dataGrid)) return;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
        }

        #region ItemsSource

        public object ItemsSource
        {
            get => (object) GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /// <summary>
        ///     ItemsSource
        /// </summary>
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(object), typeof(DataGridBehavior),
                new PropertyMetadata(null, ItemsSourceChanged));

        private static void ItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (DataGridBehavior) d;
            if (e.OldValue != null)
                behavior.OnUnsetItemsSource();

            behavior.OnSetItemsSource();
        }

        #endregion
    }
}