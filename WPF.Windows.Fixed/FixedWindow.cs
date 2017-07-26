using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Media.Effects;
using System.Windows.Media;

namespace WPF.Windows.Fixed
{
    public class FixedWindow : Window
    {
        #region Click events
        protected void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
    }
}
