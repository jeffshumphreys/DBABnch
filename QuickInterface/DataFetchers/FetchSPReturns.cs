using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuickInterface.Program;
using static QuickInterface.Globals;
using static QuickInterface.DataFetchers._DataFetcherBase;  // Statics help keep code clean.
using QuickInterface.Helpers;
using Xunit; // For Asserts

namespace QuickInterface.DataFetchers
{
    internal class SearchPersonReturns
    {
        public string ADUserGUID;
        public string ADUserLoginCd;
        public string UserNm;
        public string UserEmail;
        public string UserTitle;
        public string UserDescription;
        public string UserDept;
        public bool IsContractor;
        public bool IsTerminated;
        public bool IsLoginDisabledInDesc;
        public string MatchedUsingAlgo;
        public string MatchedOnInputs;
        public string Tag;
        public string RoleServingIn;

    }
    internal class FetchSPReturns
    {
        private ICallingInterface callingInterfaceWeWillSendMessagesBackTo;
        internal async Task<(List<SearchPersonReturns>, SPJobDef)> RunSearchPersonRtnResults(string soughtIdentifier, ICallingInterface callingInterface)
        {
            Assert.NotNull(soughtIdentifier);
            Assert.NotEmpty(soughtIdentifier);
            Assert.NotNull(callingInterface);

            callingInterfaceWeWillSendMessagesBackTo = callingInterface;

            SearchPersonReturns details = null;
            List<SearchPersonReturns> list = new List<SearchPersonReturns>(SOME_RANDOM_MINIMUM_INST_ALLOCS_SINCE_AT_LEAST_THESE_MANY);
            SPJobDef spJobDef = new SPJobDef("[Search].[Person]"); // Slow, gets detail from stack trace
            spJobDef.connStrUsed = CONN_STR;
            using var conn = new SqlConnection(CONN_STR);
            conn.InfoMessage += Conn_InfoMessageBackFromReader;
            using var cmd = new SqlCommand(spJobDef.SPName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //command.Notification = SqlNotificationRequest; SqlDependency 


            await conn.OpenAsync();

            SqlCommandBuilder.DeriveParameters(cmd); // roundtrip! NEVER SEEN IN PRODUCTION! (Before now.)  Reduces dependency on argument name, though.  Worth it.

            cmd.Parameters[1].Value = soughtIdentifier;

            spJobDef.UTCStartedOn = DateTime.UtcNow;
            var measureRunTime = new StopWatchExt();
            // TODO: Multiple return sets
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                if (callingInterface.GridFreshlyCreated == true)
                {
                    callingInterface.AddColumnToGrid("User Login");
                    callingInterface.AddColumnToGrid("User Name");
                }
                var firstRowsReturnedAt = measureRunTime.Elapsed;
                // TODO: Use reflection to define and fill.
                details = new SearchPersonReturns();
                details.ADUserLoginCd = reader["ADUserLoginCd"].ToString();
                details.UserNm = reader["UserNm"].ToString();
                list.Add(details); // Stream? Yield?
                callingInterface.SetCellAtRowColumn(details.ADUserLoginCd, FIRST_COLUMN_NO_IN_GRID);
                callingInterface.SetCellAtRowColumn(details.UserNm, FIRST_COLUMN_NO_IN_GRID + 1); // Offset in case row headers. + 1 logically.  Or if a column is hidden, then physically the row number is off by one extra.
            }

            var finishedAt = measureRunTime.Elapsed;
            spJobDef.timeTilCompleteMilliseconds = finishedAt.TotalMilliseconds.ToInt64();
            spJobDef.UTCEndedOn = DateTime.UtcNow;  // Doh! UTC dates should be a type, not a separate value!  So setting a DateTime to a DateTimeUTC would error!
            spJobDef.SPReturnValue = cmd.Parameters[RETURN_VALUE_STANDARD_INDEX].Value.ToInt32();
            if (spJobDef.SPReturnValue == null)
            {
                throw new ArgumentNullException("I do not support stored procedures that do not return a non-zero integer since that is the default return value, and there's no way of knowing the outcome.");
            }
            spJobDef.rows = list.Count; // Is this right?  What if not a row returning SP?
            spJobDef.errorNo = NO_SQL_ERROR_RETURNED;




            return (list, spJobDef);
        }

        private void Conn_InfoMessageBackFromReader(object sender, SqlInfoMessageEventArgs e)
        {
            // TODO: Write to main thread on calling form.
            var source = e.Source;
            var errors = e.Errors;
            callingInterfaceWeWillSendMessagesBackTo.WriteToMessageOutput(e.Message);
        }
    }
}
