using System;
using System.Collections.Generic;

namespace DemoAnomalyDetector.Model
{
    public class PriceInfo
    {
        public string granularity { get; set; }
        public List<Series> series { get; set; }
        public double maxAnomalyRatio { get; set; }
        public int sensitivity { get; set; }
    }

    public class Series
    {
        public DateTime timestamp { get; set; }
        public long value { get; set; }
    }
}
