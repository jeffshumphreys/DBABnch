using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using static QuickInterface.Globals;



namespace QuickInterface.UI_Views
{
    class _WinFormsCallingInterface : ICallingInterface
    {
        private Form callingForm;
        private DataGridView AGridThatWillLetCalledSPReturnRowsDirectlyToIt;
        private Control hopefullyATextControl;
        public _WinFormsCallingInterface(Form returnMessagesToThisForm, Control returnMessagesToThisControl, DataGridView WriteSPRowsToThisGrid)
        {
            callingForm = returnMessagesToThisForm;
            hopefullyATextControl = returnMessagesToThisControl;
            AGridThatWillLetCalledSPReturnRowsDirectlyToIt = WriteSPRowsToThisGrid;
            if (AGridThatWillLetCalledSPReturnRowsDirectlyToIt != null)
            {
                AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Clear();
                AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Clear();

                GridFreshlyCreated = true; // Not perfect. If the grid needs to be flushed first...
                GridHasIntentionalRows = false;
                GridHasIntentionalColumns = false;
            }
        }

        public bool AddColumnToGrid(string columnName, string type = "string")
        {
            Assert.NotNull(AGridThatWillLetCalledSPReturnRowsDirectlyToIt);

            if (type == "string")
            {
                if (AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Contains(columnName)) {
                    throw new DuplicateUIElementException($"Cannot add the same column twice {columnName}");
                }

                var colsWithSameHeading = AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Cast<DataGridViewColumn>().Where(c => c.HeaderText == columnName);
                if (colsWithSameHeading.Count() > 0)
                {
                    throw new DuplicateUIElementException($"Cannot add a column with the same heading as an existing column.");
                }

                DataGridViewTextBoxColumn newColumnToBeAdded = new DataGridViewTextBoxColumn();
                newColumnToBeAdded.HeaderText = columnName;
                newColumnToBeAdded.Name = columnName;
                AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Add(newColumnToBeAdded);
            } else
            {
                throw new NotSupportingOtherTypesYetException($"Only supporting the string type for new columns, not {type}");
            }
            //DataGridViewButtonColumn
            //DataGridViewLinkColumn
            //DataGridViewComboBoxColumn
            //DataGridViewCheckBoxColumn
            //DataGridViewImageColumn
            return true;
        }


        public bool? GridFreshlyCreated { get; set; }
        public bool? GridHasIntentionalRows { get; set; }
        public bool? GridHasIntentionalColumns { get; set; }

        public void SetCellAtRowColumn(object cellValue, int referringToColumnIndex, int referringToRowIndex = I_DONT_KNOW_JUST_ADD_A_NEW_ROW_IF_FIRST_COLUMN_OTHERWISE_USE_LAST_ROW)
        {
            int targetingRowIndex = ROW_INDEX_NOT_SET_YET;

            if (AGridThatWillLetCalledSPReturnRowsDirectlyToIt == null)
            {
                throw new UnsupportedFeatureExceptionButAGreatOppForADynamicFeature("There is no grid in the calling interface for you to write to. The developer should have it so it pops out a dynamic separate window with the grid data in it.");
            }

            if (referringToRowIndex == I_DONT_KNOW_JUST_ADD_A_NEW_ROW_IF_FIRST_COLUMN_OTHERWISE_USE_LAST_ROW)
            {
                // TODO: Verify that the previous row was filled!
                if (referringToColumnIndex == FIRST_COLUMN_NO_IN_GRID)
                {
                    // This logic is wack.
                    if (GridFreshlyCreated == true && GridHasIntentionalRows == false && AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Count == 1) // And if columns, all values are blank or unset (?) null?????
                    {
                        // Don't add a new row.  When you add columns to a grid, dumb windows adds a blank row.
                    }
                    else
                    {
                        AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Add();
                    }
                }

                targetingRowIndex = AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Count - 1;
            } else
            {
                targetingRowIndex = referringToRowIndex;
            }

            int targetingColumnIndex = referringToColumnIndex;

            if (targetingColumnIndex < 0 || targetingColumnIndex >= AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Count)
            {
                throw new ArgumentOutOfRangeException($"cannot reference column #{targetingColumnIndex} in a {AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Columns.Count} column grid.");
            }

            if (targetingRowIndex < 0 || targetingRowIndex >= AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Count)
            {
                throw new ArgumentOutOfRangeException($"cannot reference row #{targetingRowIndex} in a {AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows.Count} row grid.");
            }

            AGridThatWillLetCalledSPReturnRowsDirectlyToIt.Rows[targetingRowIndex].Cells[referringToColumnIndex].Value = cellValue?.ToString();
        }

        public void WriteToMessageOutput(string message)
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
                throw new TypeUnrecognizedException(hopefullyATextControl.GetType(), nameof(hopefullyATextControl), $" {nameof(_WinFormsCallingInterface)}.${nameof(WriteToMessageOutput)}"); // Caller?
            }
        }
    }
}
