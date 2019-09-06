using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DemoAnomalyDetector.ViewModel;

namespace DemoAnomalyDetector.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnomalyDetectorView : ContentPage
    {
        AnomalyDetectorViewModel vm;

        public AnomalyDetectorView()
        {
            InitializeComponent();

            vm = new AnomalyDetectorViewModel();
            BindingContext = vm;
        }
    }
}