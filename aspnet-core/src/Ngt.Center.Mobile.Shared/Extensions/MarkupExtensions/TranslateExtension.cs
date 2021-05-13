using System;
using Ngt.Center.Core;
using Ngt.Center.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ngt.Center.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}