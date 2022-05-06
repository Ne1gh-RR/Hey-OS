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
    /// <summary>
    /// BIOS window
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer sp = new SoundPlayer(Resource1.biosbeep);
        static SelectedCategory category = SelectedCategory.Main;
        static SelectedSection section = SelectedSection.text1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_initilised(object sender, EventArgs e)
        {
            Cursor = Cursors.None;
            selectedItem.Visibility = Visibility.Hidden;
            headerText.Visibility = Visibility.Hidden;
            MakeAllSectionsHidden();
            MakeAllSectionsOptionsHidden();
            SelectMain();
            SelectText1();
        }

        async void Keydown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    SelectSectionFromUpArrowInMain(ref section);
                    break;
                case Key.Down:
                    SelectSectionFromDownArrowInMain(ref section);
                    break;
                case Key.Left:
                    SelectCategoryFromLeftArrow(ref category);
                    break;
                case Key.Right:
                    SelectCategoryFromRightArrow(ref category);
                    break;
                case Key.Enter:

                    break;
                case Key.Escape:
                    await Task.Delay(50);
                    Environment.Exit(Environment.ExitCode);
                    break;
                case Key.F1:

                    break;
                default:
                    sp.Play();
                    break;

            }
        }

        

        
    }
}