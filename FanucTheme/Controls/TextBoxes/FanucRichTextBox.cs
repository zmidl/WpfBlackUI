using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace FanucTheme.Controls.TextBoxes
{
  public class FanucRichTextBox
   {
      public static CornerRadius GetRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(RadiusProperty);
      public static void SetRadius(DependencyObject obj, CornerRadius value) => obj.SetValue(RadiusProperty, value);
      public static readonly DependencyProperty RadiusProperty = DependencyProperty.RegisterAttached("Radius", typeof(CornerRadius), typeof(FanucRichTextBox), new PropertyMetadata(new CornerRadius(0)));

   }
}
