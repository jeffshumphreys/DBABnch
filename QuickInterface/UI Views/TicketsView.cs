using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickInterface.UI_Views
{
    public partial class TicketsView : Form
    {
        public TicketsView()
        {
            InitializeComponent();
        }

        private void RunReportForITT_Click(object sender, EventArgs e)
        {
            var reportOutput = new GenericGridView();
            reportOutput.Show();
        }

        private void PullNewData_Click(object sender, EventArgs e)
        {
            CancellationToken cancelExecutionOfSP = new CancellationToken(canceled: true);
            ////var StoredProcedureName = "GatherAndCollate.TicketsOfInterest";
            //var StoredProcedureName = "sp_who2";
            //var cmd = Program.DBABnchDbConn.CreateCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //outTxtRunProcMessages.AppendLine(StoredProcedureName, color:Color.Red);
            //cmd.CommandText = StoredProcedureName;
            //cmd.Connection.InfoMessage += Connection_InfoMessage;
            //using (var rdr = cmd.ExecuteReader())
            //{
            //    while (rdr.HasRows)
            //    {
            //        rdr.Read();
            //        outTxtRunProcMessages.AppendLine(rdr.GetString(6), color: Color.Blue);
            //    }
            //}
            //cmd.ExecuteNonQueryAsync(cancelExecutionOfSP);
        }

        private void Connection_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {
            outTxtRunProcMessages.AppendLine(e.Message);
        }

        private void TicketsView_Load(object sender, EventArgs e)
        {

        }
    }
}
