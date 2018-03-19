using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RichPresenceTest
{
    public interface ITimeSetting
    {
        [JsonIgnore]
        DateTime DateTime { get; set; }
    }

    public class TimeDifference : ITimeSetting
    {
        public long timeDifference;

        public DateTime DateTime
        {
            get
            {
                long timestamp = (long)DateTime.Now.Subtract(MainForm.unixDateTimeStart).TotalSeconds;
                timestamp += timeDifference;
                return MainForm.unixDateTimeStart.AddSeconds(timestamp);
            }
            set
            {
                timeDifference = (long)value.Subtract(DateTime.Now).TotalSeconds;
            }
        }
    }

    public class TimeStamp : ITimeSetting
    {
        public long timestamp;

        public DateTime DateTime
        {
            get
            {
                return MainForm.unixDateTimeStart.AddSeconds(timestamp);
            }
            set
            {
                timestamp = (long)value.Subtract(MainForm.unixDateTimeStart).TotalSeconds;
            }
        }
    }
}