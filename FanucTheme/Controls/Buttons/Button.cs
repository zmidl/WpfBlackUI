using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FanucTheme.Controls.Buttons
{
   public static class Button
   {
      public static void SetIsLoading(this System.Windows.Controls.Button button, bool isloading) => FanucButton.SetIsLoading(button, isloading);

      public static void GetIsLoading(this System.Windows.Controls.Button button) => FanucButton.GetIsLoading(button);
   }
}
