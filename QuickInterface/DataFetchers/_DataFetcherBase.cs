using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuickInterface.Program;
using static QuickInterface.Globals;
using Xunit;

namespace QuickInterface.DataFetchers
{
    public class _DataFetcherBase
    {
        internal class QueryJobDef
        {
            internal QueryJobDef()
            {
                // An example of how (hopefully) constants give some clarity.

                rows = ROWS_NOT_AVAILABLE_YET_FOR_COUNTING;
                UTCStartedOn = HASNT_STARTED_YET;
                UTCEndedOn = HASNT_ENDED_YET;
                var st = new System.Diagnostics.StackTrace(fNeedFileInfo: true); // More overhead!!!!
                var previousFrame = st.GetFrame(index: 1);
                fileCalledFrom = previousFrame.GetFileName();
                methodCalledFrom = previousFrame.GetMethod().Name;
                // TODO: What were the parameters?
                //previousFrame.GetMethod().GetMethodBody
                var parentOfPreviousFrame = st.GetFrame(index: 2);
                parentMethodCaller = parentOfPreviousFrame.GetMethod().Name;
            }

            public Int64? rows { get; set; }
            // IDEA: Stop storing the UOM in the name, but have it be a part of the type.  So there's a type "milliseconds", and if you assign a "microseconds" type, it divides by 1000.
            public Int64? timeTilFirstRowsMilliseconds { get; set; }
            public Int64? timeTilCompleteMilliseconds { get; set; }
            public Int64? timeTilCancelledMilliseconds { get; set; }
            public Int32? errorNo { get; set; }
            public DateTime? UTCStartedOn { get; set; }  // Have to prefix, or huge risk of treating as local time.  And th rule on names is all timestamps end in "On"
            public DateTime? UTCEndedOn { get; set; }
            public string connStrUsed { get; set; }
            public string methodCalledFrom { get; set; }
            public string fileCalledFrom { get; set; }
            public string parentMethodCaller { get; set; }
            // Program, version, release, etc.
        }

        internal class SPJobDef : QueryJobDef
        {
            private SPJobDef()
            {
                SPReturnValue = NO_RETURN_VALUE_SET_FROM_SP_CALL;
            }

            internal SPJobDef(string SPToBeRunAndTracked)
            {
                Assert.NotNull(SPToBeRunAndTracked); // Asserts in constructors???????
                Assert.NotEmpty(SPToBeRunAndTracked);
                SPName = SPToBeRunAndTracked; // May include schema, db, etc.
            }
            public Int32? SPReturnValue { get; set; }
            public string SPName { get; set; }
        }
    }
}
