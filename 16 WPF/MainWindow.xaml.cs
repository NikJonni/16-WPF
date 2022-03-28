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

namespace _16_WPF
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

        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    DoubleAnimation doubleAnimation = new DoubleAnimation();// создание экзмепляра класса
        //    //doubleAnimation.From = 150;// от какого размера ширина
        //    doubleAnimation.To = 500;// до какого размера ширина
        //    //doubleAnimation.By = 10;
        //    doubleAnimation.Duration = TimeSpan.FromSeconds(2);// время анимации
        //    //doubleAnimation.RepeatBehavior = new RepeatBehavior(2);
        //    //doubleAnimation.AccelerationRatio = 0.5;
        //    //doubleAnimation.SpeedRatio = 0.5;
        //    //doubleAnimation.AutoReverse = true;
        //    doubleAnimation.FillBehavior = FillBehavior.Stop;
        //    btn.BeginAnimation(Button.WidthProperty, doubleAnimation);// объект анимации
        //    btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

        //    ColorAnimation colorAnimation = new ColorAnimation();
        //    colorAnimation.From = Colors.Red;
        //    colorAnimation.To = Colors.Blue;
        //    colorAnimation.Duration = TimeSpan.FromSeconds(2);
        //    btn.Background = new SolidColorBrush(Colors.Red);// создание экземпляра, так как фон-кисть
        //    btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

        //}
    }
}
