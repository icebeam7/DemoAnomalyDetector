using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using DemoAnomalyDetector.Data;
using DemoAnomalyDetector.Model;
using DemoAnomalyDetector.Services;

using SkiaSharp;
using Microcharts;
using Xamarin.Forms;
using System.Linq;

namespace DemoAnomalyDetector.ViewModel
{
    public class AnomalyDetectorViewModel : BaseViewModel
    {
        private PriceInfo info;

        public PriceInfo Info
        {
            get { return info; }
            set { info = value; OnPropertyChanged(); }
        }

        private PriceResult result;

        public PriceResult Result
        {
            get { return result; }
            set { result = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Anomaly> anomalies;

        public ObservableCollection<Anomaly> Anomalies
        {
            get { return anomalies; }
            set { anomalies = value; OnPropertyChanged(); }
        }

        public Command AnalyzePriceDataCommand { get; set; }

        private Chart chart;

        public Chart Chart
        {
            get { return chart; }
            set { chart = value; OnPropertyChanged(); }
        }

        public AnomalyDetectorViewModel()
        {
            Info = PriceData.Generate();
            AnalyzePriceDataCommand = new Command(async () => await AnalyzeData());

            Chart = new LineChart() { LineMode = LineMode.Spline };

            Chart.Entries = Info.series.Select(
                (v, index) => new Microcharts.Entry(v.value)
                {
                    Color = SKColors.Blue
                });
        }

        private async Task AnalyzeData()
        {
            Anomalies = new ObservableCollection<Anomaly>();

            Result = await AnomalyDetectorService.AnalyzeData(Info);

            for (int i = 0; i < Result.IsAnomaly.Length; i++)
            {
                if (Result.IsAnomaly[i])
                {
                    var info = Info.series[i];

                    Anomalies.Add(new Anomaly()
                    {
                        Timestamp = info.timestamp,
                        Value = info.value,
                        IsPositive = Result.IsPositiveAnomaly[i]
                    });
                }
            }
        }
    }
}
