using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFLib
{
    public class Entry
    {
        public string Name1 { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int TotalCount { get; set; }
        public DateTime LastSession { get; set; }

        public Entry(string[] fields)
        {

            //workstation name
            Name1 = fields[0];

            //total time
            string[] timeParts = fields[1].Split(':');
            TotalTime = new TimeSpan(int.Parse(timeParts[0]), int.Parse(timeParts[1]), 0);

            //total count
            TotalCount = int.Parse(fields[2]);

            //last session
            LastSession = DateTime.Parse(fields[5]);

        }

    }


}
