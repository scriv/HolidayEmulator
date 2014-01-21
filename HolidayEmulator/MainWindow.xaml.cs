using Caliburn.Micro;
using HolidayEmulator.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolidayEmulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IHandle<SetLightsMessage>
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            App.EventAggregator.Subscribe(this);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Cloud.MouseLeftButtonDown += (_, __) => DragMove();

            var path = this.Cloud.Data.GetFlattenedPathGeometry();
            double progress = 0.0;

            for (int i = 1; i < 51; i++)
            {
                Point center;
                Point tangent;

                path.GetPointAtFractionLength(progress+=0.02, out center, out tangent);

                var ellipse = new Ellipse();
                Canvas.SetLeft(ellipse, center.X-5);
                Canvas.SetTop(ellipse, center.Y-5);

                var dropshadow = new DropShadowEffect();
                dropshadow.BlurRadius = 10;
                dropshadow.ShadowDepth = 0;

                ellipse.Effect = dropshadow;

                ((Canvas)this.Cloud.Parent).Children.Add(ellipse);
            }
        }

        public void Handle(SetLightsMessage message)
        {
            Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine(string.Concat("{\"lights\":[", string.Join(",", message.LightColours.Select(c => string.Concat("\"", c.ToString(), "\""))), "]}"));

                    var lights = ((Canvas)this.Cloud.Parent).Children.OfType<Ellipse>().ToArray();

                    for (int i = 0; i < 50; i++)
                    {
                        var colour = message.LightColours.ElementAt(i);

                        if (colour == Colors.Black)
                        {
                            colour = Colors.Transparent;
                        }

                        lights.ElementAt(i).Fill = new SolidColorBrush(colour);
                        ((DropShadowEffect)lights.ElementAt(i).Effect).Color = colour;
                    }
                });
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
