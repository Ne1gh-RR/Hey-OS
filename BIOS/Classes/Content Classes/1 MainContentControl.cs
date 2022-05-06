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
        public enum SystemTimeSelectedTimeFormat
        {
            hours = 1,
            minutes = 2,
            seconds = 3
        }

        public void SelectMain()
        {
            main.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
            rectMain.Fill = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            ShowMainContent();
            SelectText1();
            category = SelectedCategory.Main;
        }
        public void CancelSelectingMain()
        {
            main.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#aaaaaa"));
            rectMain.Fill = (Brush?)(new BrushConverter().ConvertFrom("#0000aa"));
        }

        public void ShowMainContent()
        {
            ShowMainSections();
            ShowMainSectionsOptions();
        }

        public void ShowMainSections()
        {
            text1.Visibility = Visibility.Visible;
            text1.Content = "  System Time:";
            text2.Visibility = Visibility.Visible;
            text2.Content = "  System Date:";

            text4.Visibility = Visibility.Visible;
            text4.Content = "  Legacy Diskette A:";
            text5.Visibility = Visibility.Visible;
            text5.Content = "  Legacy Diskette B:";

            text7.Visibility = Visibility.Visible;
            text7.Content = "▶ Primary Master";
            text8.Visibility = Visibility.Visible;
            text8.Content = "▶ Primary Slave";
            text9.Visibility = Visibility.Visible;
            text9.Content = "▶ Secondary Master";
            text10.Visibility = Visibility.Visible;
            text10.Content = "▶ Secondary Slave";

            text12.Visibility = Visibility.Visible;
            text12.Content = "▶ Keyboard Features";

            text14.Visibility = Visibility.Visible;
            text14.Content = "  System Memory:";
            text15.Visibility = Visibility.Visible;
            text15.Content = "  Extended Memory:";
            text16.Visibility = Visibility.Visible;
            text16.Content = "  Boot-time Diagnostic Screen:";
        }
        public void ShowMainSectionsOptions()
        {
            //System Time Clock
            //System Date Clock

            text4opposite.Visibility = Visibility.Visible;
            text4opposite.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF555555"));
            text4opposite.Content = "[Disabled]";
            text5opposite.Visibility = Visibility.Visible;
            text5opposite.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF555555"));
            text5opposite.Content = "[Disabled]";

            text7opposite.Visibility = Visibility.Visible;
            text7opposite.Content = "[None]";
            text8opposite.Visibility = Visibility.Visible;
            text8opposite.Content = "[None]";
            text9opposite.Visibility = Visibility.Visible;
            text9opposite.Content = "[CD-ROM]";
            text10opposite.Visibility = Visibility.Visible;
            text10opposite.Content = "[None]";

            //Do not need to be visible

            text14opposite.Visibility = Visibility.Visible;
            text14opposite.Content = "16,777,216 KB";
            text15opposite.Visibility = Visibility.Visible;
            text15opposite.Content = "2,097,152 KB";
            text16opposite.Visibility = Visibility.Visible;
            text16opposite.Foreground = (Brush?)(new BrushConverter().ConvertFrom("#FF000000"));
            text16opposite.Content = "[Disabled]";
        }

        public void SelectSectionFromDownArrowInMain(ref SelectedSection section)
        {
            switch (MainWindow.section)
            {
                case SelectedSection.text1:
                    SelectText2();
                    break;
                case SelectedSection.text2:
                    SelectText4();
                    break;


                case SelectedSection.text4:
                    SelectText5();
                    break;
                case SelectedSection.text5:
                    SelectText7();
                    break;


                case SelectedSection.text7:
                    SelectText8();
                    break;
                case SelectedSection.text8:
                    SelectText9();
                    break;
                case SelectedSection.text9:
                    SelectText10();
                    break;
                case SelectedSection.text10:
                    SelectText12();
                    break;


                case SelectedSection.text12:
                    SelectText14();
                    break;


                case SelectedSection.text14:
                    SelectText15();
                    break;
                case SelectedSection.text15:
                    SelectText16();
                    break;
                case SelectedSection.text16:
                    SelectText1();
                    break;
            }
        }
        public void SelectSectionFromUpArrowInMain(ref SelectedSection section)
        {
            switch (MainWindow.section)
            {
                case SelectedSection.text1:
                    SelectText16();
                    break;
                case SelectedSection.text2:
                    SelectText1();
                    break;


                case SelectedSection.text4:
                    SelectText2();
                    break;
                case SelectedSection.text5:
                    SelectText4();
                    break;


                case SelectedSection.text7:
                    SelectText5();
                    break;
                case SelectedSection.text8:
                    SelectText7();
                    break;
                case SelectedSection.text9:
                    SelectText8();
                    break;
                case SelectedSection.text10:
                    SelectText9();
                    break;


                case SelectedSection.text12:
                    SelectText10();
                    break;


                case SelectedSection.text14:
                    SelectText12();
                    break;
                case SelectedSection.text15:
                    SelectText14();
                    break;
                case SelectedSection.text16:
                    SelectText15();
                    break;
            }
        }

        //every 45 px
    }
}
