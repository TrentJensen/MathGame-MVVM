using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Dialogs.DialogService
{
    public static class DialogService
    {
        public static DialogResult OpenDialog()
        {
            DialogWindow win = new DialogWindow();
            win.ShowDialog();
            return DialogResult.Undefined;
        }
    }
}
