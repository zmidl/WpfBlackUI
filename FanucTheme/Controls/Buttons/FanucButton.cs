using System.Windows;
using System.Windows.Media;

namespace FanucTheme.Controls.Buttons
{
   public class FanucButton
   {
      public static bool GetIsLoading(DependencyObject obj) => (bool)obj.GetValue(IsLoadingProperty);
      public static void SetIsLoading(DependencyObject obj, bool value) => obj.SetValue(IsLoadingProperty, value);
      public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.RegisterAttached("IsLoading", typeof(bool), typeof(FanucButton), new PropertyMetadata(false));


      public static Geometry GetData(DependencyObject obj) => (Geometry)obj.GetValue(DataProperty);
      public static void SetData(DependencyObject obj, Geometry value) => obj.SetValue(DataProperty, value);
      public static readonly DependencyProperty DataProperty = DependencyProperty.RegisterAttached(nameof(Data), typeof(Geometry), typeof(FanucButton), new PropertyMetadata(null));


      public static CornerRadius GetRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(RadiusProperty);
      public static void SetRadius(DependencyObject obj, CornerRadius value)=>obj.SetValue(RadiusProperty, value);
      public static readonly DependencyProperty RadiusProperty = DependencyProperty.RegisterAttached("Radius", typeof(CornerRadius), typeof(FanucButton), new PropertyMetadata(new CornerRadius(0)));


   }
}

