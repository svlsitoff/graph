using System;
using System.Diagnostics;
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

namespace PointXY
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

         
            
          
        }
        private void ShowGrid()
        {

            Line vertL = new Line();
            vertL.X1 = 250;
            vertL.Y1 = 250;
            vertL.X2 = 250;
            vertL.Y2 = 10;
            vertL.Stroke = Brushes.Black;
            grid1.Children.Add(vertL);
            Line horL = new Line();
            horL.X1 = 10;
            horL.X2 = 500;
            horL.Y1 = 125;
            horL.Y2 = 125;
            horL.Stroke = Brushes.Black;
            grid1.Children.Add(horL);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid();
            double str1, str2, str3;
            if (input1.Text == "") { str1 = 0.0; } else
            {
                 str1 = Convert.ToDouble(input1.Text);
            }
            if (input2.Text == "") { str2 = 0.0; }
            else
            {
                str2 = Convert.ToDouble(input2.Text);
            }

            if (input3.Text == "") { str3 = 0.0; }
            else
            {
                str3 = Convert.ToDouble(input3.Text);
            }
            Polyline vertArr = new Polyline();
            vertArr.Points = new PointCollection();
            //зададим ка начальные координаты точек  середину 
            //а значит X = 250 y =  125
            double X = 250.0, Y = 125.0;
            double y;
            for(double x = 0.0; x <= 100.0; x ++)
            {
                y = str1 * x * x + str2 * x + str3;
                vertArr.Points.Add(new Point(X+x, (Y-y)));// Y уменьшать!
            }
            vertArr.Stroke = Brushes.Black;
            grid1.Children.Add(vertArr);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();

        }
    }
}
