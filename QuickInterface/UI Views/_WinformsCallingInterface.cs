using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickInterface.UI_Views
{
    class _WinformsCallingInterface : ICallingInterface
    {
        private Form callingForm;
        private Control hopefullyATextControl;
        public _WinformsCallingInterface(Form returnMessagesToThisForm, Control returnMessagesToThisControl)
        {
            callingForm = returnMessagesToThisForm;
            hopefullyATextControl = returnMessagesToThisControl;
        }
        public void WriteToOutput(string message)
        {
            if (hopefullyATextControl is TextBoxBase) // TextBox, RichTextBox
            {
                // The difference between Invoke and BeginInvoke is that BeginInvoke won't wait for the delegate to be called on the UI thread before it continues 
                MethodInvoker action = delegate { ((TextBoxBase)hopefullyATextControl).Text += $"{message}\n"; }; // Assumes on a new line.  Should check.
                ((TextBoxBase)hopefullyATextControl).BeginInvoke(action);
            }
            else
            {
                // I'm getting better at always throwing meaningful exceptions.
                throw new TypeUnrecognizedException(hopefullyATextControl.GetType(), nameof(hopefullyATextControl), $" {nameof(_WinformsCallingInterface)}.${nameof(WriteToOutput)}"); // Caller?
            }
        }
    }
}
