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
using System.Windows.Interop;
using System.Runtime.InteropServices;

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

        static FixedWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FixedWindow),
                new FrameworkPropertyMetadata(typeof(FixedWindow)));
        }

        public override void OnApplyTemplate()
        {
            Button closeButton = GetTemplateChild("closeButton") as Button;
            if (closeButton != null)
                closeButton.Click += CloseClick;

            Rectangle moveRect = GetTemplateChild("moveRectangle") as Rectangle;
            if (moveRect != null)
                moveRect.PreviewMouseDown += moveRectangle_PreviewMouseDown;

            Label WindowTitle = GetTemplateChild("WindowTitle") as Label;
            WindowTitle.Content = Title;
            WindowTitle.Foreground = Foreground;
            WindowTitle.FontFamily = FontFamily;
            WindowTitle.FontSize = FontSize;

            Image WindowIcon = GetTemplateChild("WindowIcon") as Image;
            WindowIcon.Source = Icon;

            DropShadowEffect WindowBorder = GetTemplateChild("WindowBorder") as DropShadowEffect;
            WindowBorder.Color = ((SolidColorBrush)BorderBrush).Color;

            Grid WindowBackground = GetTemplateChild("WindowBackground") as Grid;
            WindowBackground.Background = Background;

            base.OnApplyTemplate();
        }

        private void moveRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
