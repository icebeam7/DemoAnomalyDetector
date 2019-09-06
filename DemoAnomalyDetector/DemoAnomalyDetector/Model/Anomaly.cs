using System;

namespace DemoAnomalyDetector.Model
{
    public class Anomaly
    {
        public DateTime Timestamp { get; set; }
        public long Value { get; set; }
        public bool IsPositive { get; set; }
    }
}
