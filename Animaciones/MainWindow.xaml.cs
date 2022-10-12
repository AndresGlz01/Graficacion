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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animaciones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAnimaBolita_OnClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a = new();
            a.By = -70;
            a.Duration = new Duration(TimeSpan.FromSeconds(2));
            a.AutoReverse = true;
            a.AccelerationRatio = 0.25;
            a.RepeatBehavior = RepeatBehavior.Forever;
            bolitaTransform.BeginAnimation(TranslateTransform.YProperty, a);
        }
    }
}