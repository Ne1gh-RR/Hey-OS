using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIOS
{
    public partial class MainWindow
    {
        public void SelectCategoryFromRightArrow(ref SelectedCategory category)
        {
            switch (category)
            {
                case SelectedCategory.Main:
                    SelectAdvanced();
                    CancelSelectingMain();
                    break;
                case SelectedCategory.Advanced:
                    SelectSecurity();
                    CancelSelectingAdvanced();
                    break;
                case SelectedCategory.Security:
                    SelectBoot();
                    CancelSelectingSecurity();
                    break;
                case SelectedCategory.Boot:
                    SelectExit();
                    CancelSelectingBoot();
                    break;
                case SelectedCategory.Exit:
                    SelectMain();
                    CancelSelectingExit();
                    break;
            }
        }
        public void SelectCategoryFromLeftArrow(ref SelectedCategory category)
        {
            switch (category)
            {
                case SelectedCategory.Exit:
                    SelectBoot();
                    CancelSelectingExit();
                    break;
                case SelectedCategory.Boot:
                    SelectSecurity();
                    CancelSelectingBoot();
                    break;
                case SelectedCategory.Security:
                    SelectAdvanced();
                    CancelSelectingSecurity();
                    break;
                case SelectedCategory.Advanced:
                    SelectMain();
                    CancelSelectingAdvanced();
                    break;
                case SelectedCategory.Main:
                    SelectExit();
                    CancelSelectingMain();
                    break;
            }
        }
    }
}
