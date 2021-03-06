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
        public void SelectAdvanced()
        {
            advanced.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
            rectAdvanced.Fill = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            category = SelectedCategory.Advanced;
        }
        public void CancelSelectingAdvanced()
        {
            advanced.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            rectAdvanced.Fill = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
        }
    }
}
