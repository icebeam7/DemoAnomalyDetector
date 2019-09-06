using System;
using System.Collections.Generic;
using DemoAnomalyDetector.Model;

namespace DemoAnomalyDetector.Data
{
    public static class PriceData
    {
        public static PriceInfo Generate()
        {
            var priceInfo = new PriceInfo()
            {
                granularity = "daily",
                maxAnomalyRatio = 0.25,
                sensitivity = 95,
                series = new List<Series>()
                {
                    new Series() { timestamp = new DateTime(2018, 03, 01), value = 32858923 },
                    new Series() { timestamp = new DateTime(2018, 03, 02), value = 29615278 },
                    new Series() { timestamp = new DateTime(2018, 03, 03), value = 22839355 },
                    new Series() { timestamp = new DateTime(2018, 03, 04), value = 25948736 },
                    new Series() { timestamp = new DateTime(2018, 03, 05), value = 34139159 },
                    new Series() { timestamp = new DateTime(2018, 03, 06), value = 33843985 },
                    new Series() { timestamp = new DateTime(2018, 03, 07), value = 33637661 },
                    new Series() { timestamp = new DateTime(2018, 03, 08), value = 32627350 },
                    new Series() { timestamp = new DateTime(2018, 03, 09), value = 29881076 },
                    new Series() { timestamp = new DateTime(2018, 03, 10), value = 22681575 },
                    new Series() { timestamp = new DateTime(2018, 03, 11), value = 24629393 },
                    new Series() { timestamp = new DateTime(2018, 03, 12), value = 34010679 },
                    new Series() { timestamp = new DateTime(2018, 03, 13), value = 33893888 },
                    new Series() { timestamp = new DateTime(2018, 03, 14), value = 33760076 },
                    new Series() { timestamp = new DateTime(2018, 03, 15), value = 33093515 },
                    new Series() { timestamp = new DateTime(2018, 03, 16), value = 29945555 },
                    new Series() { timestamp = new DateTime(2018, 03, 17), value = 22676212 },
                    new Series() { timestamp = new DateTime(2018, 03, 18), value = 25262514 },
                    new Series() { timestamp = new DateTime(2018, 03, 19), value = 33631649 },
                    new Series() { timestamp = new DateTime(2018, 03, 20), value = 34468310 },
                    new Series() { timestamp = new DateTime(2018, 03, 21), value = 34212281 },
                    new Series() { timestamp = new DateTime(2018, 03, 22), value = 38144434 },
                    new Series() { timestamp = new DateTime(2018, 03, 23), value = 34662949 },
                    new Series() { timestamp = new DateTime(2018, 03, 24), value = 24623684 },
                    new Series() { timestamp = new DateTime(2018, 03, 25), value = 26530491 },
                    new Series() { timestamp = new DateTime(2018, 03, 26), value = 35445003 },
                    new Series() { timestamp = new DateTime(2018, 03, 27), value = 34250789 },
                    new Series() { timestamp = new DateTime(2018, 03, 28), value = 33423012 },
                    new Series() { timestamp = new DateTime(2018, 03, 29), value = 30744783 },
                    new Series() { timestamp = new DateTime(2018, 03, 30), value = 25825128 },
                    new Series() { timestamp = new DateTime(2018, 03, 31), value = 21244209 },
                    new Series() { timestamp = new DateTime(2018, 04, 01), value = 22576956 },
                    new Series() { timestamp = new DateTime(2018, 04, 02), value = 31957221 },
                    new Series() { timestamp = new DateTime(2018, 04, 03), value = 33841228 },
                    new Series() { timestamp = new DateTime(2018, 04, 04), value = 33554483 },
                    new Series() { timestamp = new DateTime(2018, 04, 05), value = 32383350 },
                    new Series() { timestamp = new DateTime(2018, 04, 06), value = 29494850 },
                    new Series() { timestamp = new DateTime(2018, 04, 07), value = 22815534 },
                    new Series() { timestamp = new DateTime(2018, 04, 08), value = 25557267 },
                    new Series() { timestamp = new DateTime(2018, 04, 09), value = 34858252 },
                    new Series() { timestamp = new DateTime(2018, 04, 10), value = 34750597 },
                    new Series() { timestamp = new DateTime(2018, 04, 11), value = 34717956 },
                    new Series() { timestamp = new DateTime(2018, 04, 12), value = 34132534 },
                    new Series() { timestamp = new DateTime(2018, 04, 13), value = 30762236 },
                    new Series() { timestamp = new DateTime(2018, 04, 14), value = 22504059 },
                    new Series() { timestamp = new DateTime(2018, 04, 15), value = 26149060 },
                    new Series() { timestamp = new DateTime(2018, 04, 16), value = 35250105 },
                }
            };

            return priceInfo;
        }
    }
}
