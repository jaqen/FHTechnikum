using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFCalculator
{
    /// <summary>
    /// MyTextBox
    /// </summary>
    class MyTextBox : System.Windows.Controls.TextBox
    {
        protected override void OnPreviewGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewGotKeyboardFocus(e);
        }
 
    }
}
