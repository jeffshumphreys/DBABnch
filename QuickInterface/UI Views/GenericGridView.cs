using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuickInterface.UI_Views
{
    public partial class GenericGridView : Form
    {
        public GenericGridView()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GenericGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBABnch_LOCALDataSet.TicketsOverMidMonth' table. You can move, or remove it, as needed.
            this.ticketsOverMidMonthTableAdapter.Fill(this.dBABnch_LOCALDataSet.TicketsOverMidMonth);

        }

        private void exportGridDataToExcel_Click(object sender, EventArgs e)
        {
            genericGridViewDataGrid.SelectAll();
            DataObject dataObj = genericGridViewDataGrid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}

