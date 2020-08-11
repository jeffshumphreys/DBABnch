using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickInterface
{
    public static class Globals
    {
        public const Int32 NO_RETURN_VALUE_SET_FROM_SP_CALL = -2;  //
        public const int RETURN_VALUE_STANDARD_INDEX = 0;
        public const int ROWS_NOT_AVAILABLE_YET_FOR_COUNTING = -1;
        public const int NO_ROWS_RETURNED = -2; // Not same as 0 rows returned.
        public const int SP_DIDNT_EXPLICITLY_RETURN_A_VALUE = 0;  // Never EXPLICITLY RETURN A ZERO!
        public const int SP_SUCCEEDED_EXACTLY_AS_REQUESTED = 1; // I found it!
        public const int SP_SUCCEEDED_RETURNED_POSSIBLE_OPTIONS = 2; // You searched for "Jeff" and I found 2 AD entries, so you decide.
        public const int SP_FAILED_TO_FIND_WHAT_WAS_REQUESTED = 5; // But not an error, just that you asked to find "Humpty Dumpty" and he's not in AD.
        public const int SP_FAILED_DUE_TO_STRUCTURAL_FLAW = -2; // i.e., SPs compile fine even if tables and SPs referenced aren't there, but you get a runtime error when it hits that line.
        public const int SP_REACHED_UNREACHABLE_CODE = -3; // Fell thru what was supposed complete set of conditions.

        public const int SOME_RANDOM_MINIMUM_INST_ALLOCS_SINCE_AT_LEAST_THESE_MANY = 10;
        public const int NO_SQL_ERROR_RETURNED = -1;
        public const long CONVERSION_FROM_STRING_FAILED = long.MinValue + 1;  // Nice to know, right?
        public static DateTime HASNT_STARTED_YET = DateTime.MinValue.AddMilliseconds(1.0); // DETERMINISTIC?????
        public static DateTime HASNT_ENDED_YET = DateTime.MinValue.AddMilliseconds(2.0);
        public const int I_DONT_KNOW_JUST_ADD_A_NEW_ROW_IF_FIRST_COLUMN_OTHERWISE_USE_LAST_ROW = -3;
        public const int FIRST_COLUMN_NO_IN_GRID = 0;
        public const int GRID_HAS_NO_ROWS_IN_IT = 0;
        public const int ROW_INDEX_NOT_SET_YET = -2;
    }
}
