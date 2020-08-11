using System;
using System.Drawing;
using System.Windows.Forms;
using static QuickInterface.Globals;

namespace QuickInterface
{
    public static class ClassExtenders
    {
        // https://www.codeproject.com/Articles/12197/Richer-RichTextBox-Part-2
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int GetCaretPos(ref Point lpPoint);

        public static void AppendLine(this TextBoxBase textBox, string message)
        {
            switch (textBox)
            {
                case RichTextBox richTextBox:

                    richTextBox.AppendLine(message, richTextBox.SelectionColor);
                    break;
                default:
                    textBox.AppendLine(message);
                    break;
            }
        }
        // Always when adding a line of text, I need to make sure that 1) I am on a new line and 2) add a new line after.
        // If we do the old-fashioned programmer way of just alway \n at the beginning, we end up an unreadable mess of empty lines.
        // And hide the complexity of fonts, colors, etc.
        public static void AppendLine(this RichTextBox richTextBox, string message, Color color)
        {
           if (richTextBox.CurrentColumn() > 0)
                richTextBox.AppendText(Environment.NewLine);
            Color saveOffColor = richTextBox.SelectionColor;
            richTextBox.SelectionColor = color;
            richTextBox.AppendText(message);
            richTextBox.SelectionColor = saveOffColor;
            richTextBox.AppendText(Environment.NewLine);
        }

        private static int GetCorrection(RichTextBox e, int index)
        {
            Point pt1 = Point.Empty;
            GetCaretPos(ref pt1);
            Point pt2 = e.GetPositionFromCharIndex(index);

            if (pt1 != pt2)
                return 1;
            else
                return 0;
        }

        public static int Line(RichTextBox e, int index)
        {
            int correction = GetCorrection(e, index);
            return e.GetLineFromCharIndex(index) - correction + 1;
        }

        private static int Column(RichTextBox e, int index1)
        {
            int correction = GetCorrection(e, index1);
            Point p = e.GetPositionFromCharIndex(index1 - correction);

            if (p.X == 1)
                return 1;

            p.X = 0;
            int index2 = e.GetCharIndexFromPosition(p);

            int col = index1 - index2 + 1;

            return col;
        }

        public static int CurrentColumn(this RichTextBox richTextBox)
        {
            return Column(richTextBox, richTextBox.SelectionStart);
        }

        public static int CurrentLine(this RichTextBox richTextBox)
        {
            return Line(richTextBox, richTextBox.SelectionStart);
        }

        public static int CurrentPosition(this RichTextBox richTextBox)
        {
            return richTextBox.SelectionStart;
        }

        public static int SelectionEnd(this RichTextBox richTextBox)
        {
            return richTextBox.SelectionStart + richTextBox.SelectionLength;
        }

        public static int? ToInt32(this object o)
        {
            int attempt;
            if (Int32.TryParse(o.ToString(), out attempt)) return attempt;
            return null;
        }

        public static long? ToInt64(this double floatingpointnumber)
        {
            long attempt;
            try
            {
                attempt = Convert.ToInt64(floatingpointnumber);
            }
            catch (InvalidCastException e)
            {
                return CONVERSION_FROM_STRING_FAILED;
            }

            return attempt;
        }

    }
}