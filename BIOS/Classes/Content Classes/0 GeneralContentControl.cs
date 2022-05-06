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
        public enum SelectedCategory
        {
            Main = 1,
            Advanced = 2,
            Security = 3,
            Boot = 4,
            Exit = 5
        }
        public enum SelectedSection
        {
            text1 = 1,
            text2 = 2,
            text3 = 3,
            text4 = 4,
            text5 = 5,
            text6 = 6,
            text7 = 7,
            text8 = 8,
            text9 = 9,
            text10 = 10,
            text11 = 11,
            text12 = 12,
            text13 = 13,
            text14 = 14,
            text15 = 15,
            text16 = 16,
            text17 = 17,
        }

        // 😧
        public void SelectText1()
        {
            DeselectSelectedSections();
            text1.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text1;
        }
        public void SelectText2()
        {
            DeselectSelectedSections();
            text2.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text2;
        }
        public void SelectText3()
        {
            DeselectSelectedSections();
            text3.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text3;
        }
        public void SelectText4()
        {
            DeselectSelectedSections();
            text4.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text4;
        }
        public void SelectText5()
        {
            DeselectSelectedSections();
            text5.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text5;
        }
        public void SelectText6()
        {
            DeselectSelectedSections();
            text6.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text6;
        }
        public void SelectText7()
        {
            DeselectSelectedSections();
            text7.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text7;
        }
        public void SelectText8()
        {
            DeselectSelectedSections();
            text8.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text8;
        }
        public void SelectText9()
        {
            DeselectSelectedSections();
            text9.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text9;
        }
        public void SelectText10()
        {
            DeselectSelectedSections();
            text10.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text10;
        }
        public void SelectText11()
        {
            DeselectSelectedSections();
            text11.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text11;
        }
        public void SelectText12()
        {
            DeselectSelectedSections();
            text12.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text12;
        }
        public void SelectText13()
        {
            DeselectSelectedSections();
            text13.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text13;
        }
        public void SelectText14()
        {
            DeselectSelectedSections();
            text14.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text14;
        }
        public void SelectText15()
        {
            DeselectSelectedSections();
            text15.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text15;
        }
        public void SelectText16()
        {
            DeselectSelectedSections();
            text16.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text16;
        }
        public void SelectText17()
        {
            DeselectSelectedSections();
            text17.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FFFFFF"));
            section = SelectedSection.text17;
        }


        public void DeselectSelectedSections()
        {
            text1.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text2.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text3.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text4.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text5.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text6.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text7.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text8.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text9.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text10.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text11.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text12.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text13.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text14.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text15.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text16.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
            text17.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF0000AA"));
        }

        public void MakeAllSectionsHidden()
        {
            text1.Visibility = Visibility.Hidden;
            text2.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden;
            text4.Visibility = Visibility.Hidden;
            text5.Visibility = Visibility.Hidden;
            text6.Visibility = Visibility.Hidden;
            text7.Visibility = Visibility.Hidden;
            text8.Visibility = Visibility.Hidden;
            text9.Visibility = Visibility.Hidden;
            text10.Visibility = Visibility.Hidden;
            text11.Visibility = Visibility.Hidden;
            text12.Visibility = Visibility.Hidden;
            text13.Visibility = Visibility.Hidden;
            text14.Visibility = Visibility.Hidden;
            text15.Visibility = Visibility.Hidden;
            text16.Visibility = Visibility.Hidden;
            text17.Visibility = Visibility.Hidden;
        }
        public void MakeAllSectionsOptionsHidden()
        {
            text1opposite.Visibility = Visibility.Hidden;
            text2opposite.Visibility = Visibility.Hidden;
            text3opposite.Visibility = Visibility.Hidden;
            text4opposite.Visibility = Visibility.Hidden;
            text5opposite.Visibility = Visibility.Hidden;
            text6opposite.Visibility = Visibility.Hidden;
            text7opposite.Visibility = Visibility.Hidden;
            text8opposite.Visibility = Visibility.Hidden;
            text9opposite.Visibility = Visibility.Hidden;
            text10opposite.Visibility = Visibility.Hidden;
            text11opposite.Visibility = Visibility.Hidden;
            text12opposite.Visibility = Visibility.Hidden;
            text13opposite.Visibility = Visibility.Hidden;
            text14opposite.Visibility = Visibility.Hidden;
            text15opposite.Visibility = Visibility.Hidden;
            text16opposite.Visibility = Visibility.Hidden;
            text17opposite.Visibility = Visibility.Hidden;
        }
    }
}
