using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

namespace SQLServerObjects
{
   
    public class Functions
    {
        [SqlFunction]
        public static SqlString Hello()
        {
            return "Hello world!";
        }

        [SqlFunction]
        public static SqlInt32 Reduce(SqlSingle total_time_per_room, SqlInt32 total_count_per_room)
        {

            int reduce = 0;

            try
            {
                while (((total_time_per_room / (total_count_per_room - reduce)) / 80) < 3.5f)
                {
                    ++reduce;
                }
            }
            catch
            { }



            return reduce;
        }
    }
}
