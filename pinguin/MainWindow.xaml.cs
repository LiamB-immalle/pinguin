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
            Drawpoot(370);
            Drawpoot(560);
            Drawarm(90, 150, 0, 90, 250);
            Drawarm(500, 120, 630, 500, 280);

            Ellipse pbody = new Ellipse();
            pbody.Width = 500;
            pbody.Height = 500;
            pbody.StrokeThickness = 4;
            pbody.Margin = new Thickness(300, 100, 0, 0);
            pbody.Fill = new SolidColorBrush(Colors.Black);
            canvas.Children.Add(pbody);

            Ellipse pbuik = new Ellipse();
            pbuik.Width = 330;
            pbuik.Height = 200;
            pbuik.StrokeThickness = 4;
            pbuik.Margin = new Thickness(385, 390, 0, 0);
            pbuik.Fill = new SolidColorBrush(Colors.White);
            canvas.Children.Add(pbuik);

            Drawoog(180, 200, 360, 170, new SolidColorBrush(Colors.White));
            Drawoog(150, 150, 570, 215, new SolidColorBrush(Colors.White));
            Drawoog(70, 70, 460, 260, new SolidColorBrush(Colors.Black));
            Drawoog(60, 60, 580, 270, new SolidColorBrush(Colors.Black));
            
            Polygon psnavel = new Polygon();
            psnavel.Points = new PointCollection() { new Point(280, 215), new Point(400, 205), new Point(350, 300) };
            psnavel.Margin = new Thickness(234, 164, 0, 0);
            psnavel.StrokeThickness = 8;
            psnavel.Stroke = new SolidColorBrush(Colors.Orange);
            psnavel.Fill = new SolidColorBrush(Colors.Yellow);
            canvas.Children.Add(psnavel);
        }
        private void Drawpoot(int a)
        {
            Ellipse ppoot = new Ellipse();
            ppoot.Width = 150;
            ppoot.Height = 100;
            ppoot.StrokeThickness = 8;
            ppoot.Stroke = new SolidColorBrush(Colors.Orange);
            ppoot.Margin = new Thickness(a, 550, 0, 0);
            ppoot.Fill = new SolidColorBrush(Colors.Yellow);
            canvas.Children.Add(ppoot);
        }
        private void Drawoog(int a, int b, int c, int d, SolidColorBrush kleur)
        {
            Ellipse eye = new Ellipse();
            eye.Width = a;
            eye.Height = b;
            eye.StrokeThickness = 4;
            eye.Margin = new Thickness(c, d, 0, 0);
            eye.Fill = kleur;
            canvas.Children.Add(eye);
        }
        private void Drawarm(int a, int b, int c, int d, int e)
        {
            Polygon parm = new Polygon();
            parm.Points = new PointCollection() { new Point(a, b), new Point(c, 200), new Point(d, e) };
            parm.Margin = new Thickness(234, 164, 0, 0);
            parm.StrokeThickness = 4;
            parm.Fill = new SolidColorBrush(Colors.Black);
            canvas.Children.Add(parm);
        }
    }
}
