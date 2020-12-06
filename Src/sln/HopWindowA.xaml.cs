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
using System.Windows.Shapes;

namespace AAV.WpfTheme.Model.App
{
  /// <summary>
  /// Interaction logic for HopWindowA.xaml
  /// </summary>
  public partial class HopWindowA : WPF.Base.WindowBase
  {
    public HopWindowA()
    {
      InitializeComponent(); tb0.Text = $"{DateTime.Now:mm:ss.f}";
    }
  }
}
