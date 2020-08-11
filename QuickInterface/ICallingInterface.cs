using static QuickInterface.Globals;

namespace QuickInterface
{
    internal interface ICallingInterface
    {
        public void WriteToMessageOutput(string message);
        public void SetCellAtRowColumn(object cellValue, int columnNo, int rowNo = I_DONT_KNOW_JUST_ADD_A_NEW_ROW_IF_FIRST_COLUMN_OTHERWISE_USE_LAST_ROW);
        public bool? GridFreshlyCreated { get; set; }
        public bool? GridHasIntentionalRows { get; set; }
        public bool AddColumnToGrid(string columnName, string type = "string");
        public bool? GridHasIntentionalColumns { get; set; }
    }
}