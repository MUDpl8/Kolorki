using Microsoft.Maui.Controls.Compatibility.Platform;

namespace Kolorki
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = Color.FromRgb(SliderR.Value, SliderG.Value, SliderB.Value);
            kwadrat.Fill = new SolidColorBrush(color);
        }
    }

}
