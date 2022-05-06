using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BIOS
{
    public partial class MainWindow
    {
        public void SelectBoot()
        {
            boot.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
            rectBoot.Fill = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            category = SelectedCategory.Boot;
        }
        public void CancelSelectingBoot()
        {
            boot.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            rectBoot.Fill = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
        }
    }
}
