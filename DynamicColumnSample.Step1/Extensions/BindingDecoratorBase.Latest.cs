using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace DynamicColumnSample.Step1.Extensions
{
    /// <summary>
    ///     A base class for custom markup extension which provides properties
    ///     that can be found on regular <see cref="Binding" /> markup extension.<br />
    ///     See: http://www.hardcodet.net/2008/04/wpf-custom-binding-class
    /// </summary>
    [MarkupExtensionReturnType(typeof(object))]
    public abstract class BindingDecoratorBase : MarkupExtension
    {
        /// <summary>
        ///     The decorated binding class.
        /// </summary>
        private Binding _binding = new Binding();


        /// <summary>
        ///     This basic implementation just sets a binding on the targeted
        ///     <see cref="DependencyObject" /> and returns the appropriate
        ///     <see cref="BindingExpressionBase" /> instance.<br />
        ///     All this work is delegated to the decorated <see cref="Binding" />
        ///     instance.
        /// </summary>
        /// <returns>
        ///     The object value to set on the property where the extension is applied.
        ///     In case of a valid binding expression, this is a <see cref="BindingExpressionBase" />
        ///     instance.
        /// </returns>
        /// <param name="provider">
        ///     Object that can provide services for the markup
        ///     extension.
        /// </param>
        public override object ProvideValue(IServiceProvider provider)
        {
            //create a binding and associate it with the target
            return Binding1.ProvideValue(provider);
        }


        /// <summary>
        ///     Validates a service provider that was submitted to the <see cref="ProvideValue" />
        ///     method. This method checks whether the provider is null (happens at design time),
        ///     whether it provides an <see cref="IProvideValueTarget" /> service, and whether
        ///     the service's <see cref="IProvideValueTarget.TargetObject" /> and
        ///     <see cref="IProvideValueTarget.TargetProperty" /> properties are valid
        ///     <see cref="DependencyObject" /> and <see cref="DependencyProperty" />
        ///     instances.
        /// </summary>
        /// <param name="provider">The provider to be validated.</param>
        /// <param name="target">The binding target of the binding.</param>
        /// <param name="dp">The target property of the binding.</param>
        /// <returns>True if the provider supports all that's needed.</returns>
        protected virtual bool TryGetTargetItems(IServiceProvider provider, out DependencyObject target,
            out DependencyProperty dp)
        {
            target = null;
            dp = null;

            //create a binding and assign it to the target
            var service = (IProvideValueTarget) provider?.GetService(typeof(IProvideValueTarget));
            if (service == null) return false;

            //we need dependency objects / properties
            target = service.TargetObject as DependencyObject;
            dp = service.TargetProperty as DependencyProperty;
            return target != null && dp != null;
        }


        //check documentation of the Binding class for property information

        #region properties

        /// <summary>
        ///     The decorated binding class.
        /// </summary>
        [Browsable(false)]
        public Binding Binding
        {
            get => Binding1;
            set => Binding1 = value;
        }


        [DefaultValue(null)]
        public object AsyncState
        {
            get => Binding1.AsyncState;
            set => Binding1.AsyncState = value;
        }

        [DefaultValue(false)]
        public bool BindsDirectlyToSource
        {
            get => Binding1.BindsDirectlyToSource;
            set => Binding1.BindsDirectlyToSource = value;
        }

        [DefaultValue(null)]
        public IValueConverter Converter
        {
            get => Binding1.Converter;
            set => Binding1.Converter = value;
        }

        [DefaultValue(null)]
        public object TargetNullValue
        {
            get => Binding1.TargetNullValue;
            set => Binding1.TargetNullValue = value;
        }

        [TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
        [DefaultValue(null)]
        public CultureInfo ConverterCulture
        {
            get => Binding1.ConverterCulture;
            set => Binding1.ConverterCulture = value;
        }

        [DefaultValue(null)]
        public object ConverterParameter
        {
            get => Binding1.ConverterParameter;
            set => Binding1.ConverterParameter = value;
        }

        [DefaultValue(null)]
        public string ElementName
        {
            get => Binding1.ElementName;
            set => Binding1.ElementName = value;
        }

        [DefaultValue(null)]
        public object FallbackValue
        {
            get => Binding1.FallbackValue;
            set => Binding1.FallbackValue = value;
        }

        [DefaultValue(false)]
        public bool IsAsync
        {
            get => Binding1.IsAsync;
            set => Binding1.IsAsync = value;
        }

        [DefaultValue(BindingMode.Default)]
        public BindingMode Mode
        {
            get => Binding1.Mode;
            set => Binding1.Mode = value;
        }

        [DefaultValue(false)]
        public bool NotifyOnSourceUpdated
        {
            get => Binding1.NotifyOnSourceUpdated;
            set => Binding1.NotifyOnSourceUpdated = value;
        }

        [DefaultValue(false)]
        public bool NotifyOnTargetUpdated
        {
            get => Binding1.NotifyOnTargetUpdated;
            set => Binding1.NotifyOnTargetUpdated = value;
        }

        [DefaultValue(false)]
        public bool NotifyOnValidationError
        {
            get => Binding1.NotifyOnValidationError;
            set => Binding1.NotifyOnValidationError = value;
        }

        [DefaultValue(null)]
        public PropertyPath Path
        {
            get => Binding1.Path;
            set => Binding1.Path = value;
        }

        [DefaultValue(null)]
        public RelativeSource RelativeSource
        {
            get => Binding1.RelativeSource;
            set => Binding1.RelativeSource = value;
        }

        [DefaultValue(null)]
        public object Source
        {
            get => Binding1.Source;
            set => Binding1.Source = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UpdateSourceExceptionFilterCallback UpdateSourceExceptionFilter
        {
            get => Binding1.UpdateSourceExceptionFilter;
            set => Binding1.UpdateSourceExceptionFilter = value;
        }

        [DefaultValue(UpdateSourceTrigger.Default)]
        public UpdateSourceTrigger UpdateSourceTrigger
        {
            get => Binding1.UpdateSourceTrigger;
            set => Binding1.UpdateSourceTrigger = value;
        }

        [DefaultValue(false)]
        public bool ValidatesOnDataErrors
        {
            get => Binding1.ValidatesOnDataErrors;
            set => Binding1.ValidatesOnDataErrors = value;
        }

        [DefaultValue(false)]
        public bool ValidatesOnExceptions
        {
            get => Binding1.ValidatesOnExceptions;
            set => Binding1.ValidatesOnExceptions = value;
        }

        [DefaultValue(null)]
        public string XPath
        {
            get => Binding1.XPath;
            set => Binding1.XPath = value;
        }

        [DefaultValue(null)] public Collection<ValidationRule> ValidationRules => Binding1.ValidationRules;

        [DefaultValue(null)]
        public string StringFormat
        {
            get => Binding1.StringFormat;
            set => Binding1.StringFormat = value;
        }

        [DefaultValue("")]
        public string BindingGroupName
        {
            get => Binding1.BindingGroupName;
            set => Binding1.BindingGroupName = value;
        }
        public Binding Binding1 { get => Binding2; set => Binding2 = value; }
        public Binding Binding2 { get => _binding; set => _binding = value; }
        public Binding Binding3 { get => _binding; set => _binding = value; }

        #endregion
    }
}