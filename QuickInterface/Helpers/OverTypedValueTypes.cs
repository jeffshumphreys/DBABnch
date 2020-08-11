using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickInterface.Helpers
{
    public struct ColumnWiseInt
    {
        public ColumnWiseInt(int b)
        {
            columnNo = b;
        }
        int columnNo;
    }
    public struct RowWiseInt
    {
        public RowWiseInt(int a)
        {
            rowNo = a;
        }
        int rowNo;
        public static RowWiseInt operator +(RowWiseInt a, ColumnWiseInt b)
        {
            throw new IncompatibleTypesException("Cannot assign a row to a column");
        }
        public static RowWiseInt operator +(RowWiseInt a, RowWiseInt b)
        {
            return new RowWiseInt(a.rowNo + b.rowNo);
        }
    }

    public struct Milliseconds
    {
        public Int64 time;
    }

    public struct Seconds
    {
        public Int64 time;
        public static Seconds operator +(Seconds a, Milliseconds b)
        {
            Seconds time = new Seconds();
            time.time = a.time + (b.time * 1000);
            return time;
        }
    }
}
