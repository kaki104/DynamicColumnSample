using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DynamicColumnSample.Step1.Extensions
{
    public class BindingEx : BindingDecoratorBase
    {
        public string PathFormatString { get; set; }

        public override object ProvideValue(IServiceProvider provider)
        {
            //delegate binding creation etc. to the base class
            var val = base.ProvideValue(provider);

            //try to get bound items for our custom work
            DependencyObject targetObject;
            DependencyProperty targetProperty;
            bool status = TryGetTargetItems(provider, out targetObject,
                out targetProperty);

            return val;
        }
    }
}
