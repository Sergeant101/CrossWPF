using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using ReactiveUI;

namespace Program.Resources.Property
{
    public static class ScrollValue
    {

        public static void SetHorizontalScrollBarValue(AvaloniaObject element, double value)
        {
            element.SetValue(HorizontalScrollBarValueProperty, value);
        }

        public static double GetHorizontalScrollBarValue(AvaloniaObject element)
        {
            return element.GetValue(HorizontalScrollBarValueProperty);
        }

        public static readonly AttachedProperty<double> HorizontalScrollBarValueProperty = 
            AvaloniaProperty.RegisterAttached<ScrollViewer, Control, double>
                ("HorizontalScrollBarValue");
    }
}