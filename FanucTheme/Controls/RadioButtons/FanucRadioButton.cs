using FanucTheme.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FanucTheme.Controls.RadioButtons
{
   public class FanucRadioButton
   {
      public static Brush GetOptionMarkColor(DependencyObject obj) => (Brush)obj.GetValue(OptionMarkColorProperty);
      public static void SetOptionMarkColor(DependencyObject obj, Brush value) => obj.SetValue(OptionMarkColorProperty, value);
      public static readonly DependencyProperty OptionMarkColorProperty = DependencyProperty.RegisterAttached("OptionMarkColor", typeof(Brush), typeof(FanucRadioButton), new PropertyMetadata(Brushes.DimGray));

      public static OptionMarkPlace GetOptionMarkPlace(DependencyObject obj) => (OptionMarkPlace)obj.GetValue(OptionMarkPlaceProperty);
      public static void SetOptionMarkPlace(DependencyObject obj, OptionMarkPlace value) => obj.SetValue(OptionMarkPlaceProperty, value);
      public static readonly DependencyProperty OptionMarkPlaceProperty = DependencyProperty.RegisterAttached("OptionMarkPlace", typeof(OptionMarkPlace), typeof(FanucRadioButton), new PropertyMetadata(OptionMarkPlace.Left, (d, e) =>
       {
          //var radioButton = d as RadioButton;
          //var content = radioButton.Template?.FindName("contentPresenter", radioButton);
          //var border = radioButton.Template?.FindName("radioButtonBorder", radioButton);
          //if (content != null && border != null)
          //{
          //   var contentElement = content as UIElement;
          //   var markElement = border as UIElement;
          //   if (e.NewValue != e.OldValue)
          //   {
          //      var place = (OptionMarkPlace)e.NewValue;
          //      switch (place)
          //      {
          //         case OptionMarkPlace.Left: { Grid.SetColumn(markElement, 0); Grid.SetColumn(contentElement, 1); break; }
          //         case OptionMarkPlace.Right: { Grid.SetColumn(markElement, 1); Grid.SetColumn(contentElement, 0); break; }
          //         default: break;
          //      }
          //   }
          //}
       }));
   }
}
