using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Windows.Fixed;
using WPF.Windows.Maximizable;
using WPF.Windows.Minimizable;
using WPF.Windows.Resizable;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //public partial class MainWindow : MinimizableWindow
    public partial class MainWindow : ResizableWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
