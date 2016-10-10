using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace pinguin
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ellipse plpoot = new Ellipse();
            plpoot.Width = 150;
            plpoot.Height = 100;
            plpoot.StrokeThickness = 8;
            plpoot.Stroke = new SolidColorBrush(Colors.Orange);
            plpoot.Margin = new Thickness(370, 550, 0, 0);
            plpoot.Fill = new SolidColorBrush(Colors.Yellow);
            pop.Children.Add(plpoot);

            Ellipse prpoot = new Ellipse();
            prpoot.Width = 150;
            prpoot.Height = 100;
            prpoot.StrokeThickness = 8;
            prpoot.Stroke = new SolidColorBrush(Colors.Orange);
            prpoot.Margin = new Thickness(560, 550, 0, 0);
            prpoot.Fill = new SolidColorBrush(Colors.Yellow);
            pop.Children.Add(prpoot);

            Ellipse pbody = new Ellipse();
            pbody.Width = 500;
            pbody.Height = 500;
            pbody.StrokeThickness = 4;
            pbody.Margin = new Thickness(300, 100, 0, 0);
            pbody.Fill = new SolidColorBrush(Colors.Black);
            pop.Children.Add(pbody);

            Ellipse pbuik = new Ellipse();
            pbuik.Width = 330;
            pbuik.Height = 200;
            pbuik.StrokeThickness = 4;
            pbuik.Margin = new Thickness(385, 390, 0, 0);
            pbuik.Fill = new SolidColorBrush(Colors.White);
            pop.Children.Add(pbuik);

            Ellipse ploog = new Ellipse();
            ploog.Width = 180;
            ploog.Height = 200;
            ploog.StrokeThickness = 4;
            ploog.Margin = new Thickness(360, 170, 0, 0);
            ploog.Fill = new SolidColorBrush(Colors.White);
            pop.Children.Add(ploog);

            Ellipse proog = new Ellipse();
            proog.Width = 150;
            proog.Height = 150;
            proog.StrokeThickness = 4;
            proog.Margin = new Thickness(570, 215, 0, 0);
            proog.Fill = new SolidColorBrush(Colors.White);
            pop.Children.Add(proog);

            Ellipse pliris = new Ellipse();
            pliris.Width = 70;
            pliris.Height = 70;
            pliris.StrokeThickness = 4;
            pliris.Margin = new Thickness(460, 260, 0, 0);
            pliris.Fill = new SolidColorBrush(Colors.Black);
            pop.Children.Add(pliris);

            Ellipse priris = new Ellipse();
            priris.Width = 60;
            priris.Height = 60;
            priris.StrokeThickness = 4;
            priris.Margin = new Thickness(580, 270, 0, 0);
            priris.Fill = new SolidColorBrush(Colors.Black);
            pop.Children.Add(priris);

            Polygon psnavel = new Polygon();
            psnavel.Points = new PointCollection() { new Point(280, 215), new Point(400, 205), new Point(350, 300) };
            psnavel.Margin = new Thickness(234, 164, 0, 0);
            psnavel.StrokeThickness = 8;
            psnavel.Stroke = new SolidColorBrush(Colors.Orange);
            psnavel.Fill = new SolidColorBrush(Colors.Yellow);
            pop.Children.Add(psnavel);

            Polygon plarm = new Polygon();
            plarm.Points = new PointCollection() { new Point(90, 150), new Point(0, 200), new Point(90, 250) };
            plarm.Margin = new Thickness(234, 164, 0, 0);
            plarm.StrokeThickness = 4;
            plarm.Fill = new SolidColorBrush(Colors.Black);
            pop.Children.Add(plarm);

            Polygon prarm = new Polygon();
            prarm.Points = new PointCollection() { new Point(500, 120), new Point(630, 200), new Point(500, 280) };
            prarm.Margin = new Thickness(234, 164, 0, 0);
            prarm.StrokeThickness = 4;
            prarm.Fill = new SolidColorBrush(Colors.Black);
            pop.Children.Add(prarm);
        }
    }
}
