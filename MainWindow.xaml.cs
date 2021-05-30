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

namespace CryptoMan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isMenuOpen;
        public MainWindow()
        {
            InitializeComponent();

        }

        // Раскрыть/Свернуть меню
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if (MenuGrid.Width == 255) {isMenuOpen = true;} else { isMenuOpen = false; }

            CubicEase easing = new CubicEase();
            easing.EasingMode = EasingMode.EaseInOut;

            //Анимация меню раскрытие
            DoubleAnimation MenuGridAnimationOpen = new DoubleAnimation();
            MenuGridAnimationOpen.From = MenuGrid.MinWidth;
            MenuGridAnimationOpen.To = MenuGrid.MaxWidth;
            MenuGridAnimationOpen.Duration = TimeSpan.FromSeconds(0.1);
            MenuGridAnimationOpen.EasingFunction = easing;

            //Анимация меню сворачивание
            DoubleAnimation MenuGridAnimationClose = new DoubleAnimation();
            MenuGridAnimationClose.From = MenuGrid.MaxWidth;
            MenuGridAnimationClose.To = MenuGrid.MinWidth;
            MenuGridAnimationClose.Duration = TimeSpan.FromSeconds(0.1);
            MenuGridAnimationClose.EasingFunction = easing;

            //Анимация фрейма
            ThicknessAnimation MainFrameAnimationClose = new ThicknessAnimation();
            ThicknessAnimation MainFrameAnimationOpen = new ThicknessAnimation();
            Thickness marginclosed = new Thickness
            {
                Left = 0,
                Right = 0,
                Top = 0,
                Bottom = 0
            };
            Thickness marginopened = new Thickness
            {
                Left = 255,
                Right = 0,
                Top = 0,
                Bottom = 0
            };
            MainFrameAnimationClose.From = marginopened;
            MainFrameAnimationClose.To = marginclosed;
            MainFrameAnimationClose.Duration = TimeSpan.FromSeconds(0.1);
            MainFrameAnimationClose.EasingFunction = easing;

            MainFrameAnimationOpen.From = marginclosed;
            MainFrameAnimationOpen.To = marginopened;
            MainFrameAnimationOpen.Duration = TimeSpan.FromSeconds(0.1);
            MainFrameAnimationOpen.EasingFunction = easing;


            if (isMenuOpen == true)
            {
                //MenuGrid.Width = MenuGrid.MinWidth;
                isMenuOpen = false;
                MenuGrid.BeginAnimation(Grid.WidthProperty, MenuGridAnimationClose);
                MainFrame.BeginAnimation(Frame.MarginProperty, MainFrameAnimationClose);
            } else if (isMenuOpen == false) {
                //MenuGrid.Width = MenuGrid.MaxWidth;
                isMenuOpen = true;
                MenuGrid.BeginAnimation(Grid.WidthProperty, MenuGridAnimationOpen);
                MainFrame.BeginAnimation(Frame.MarginProperty, MainFrameAnimationOpen);
            }
        }
        
        //Кнопки меню
        private void Nav2P1(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/Page1.xaml", UriKind.Relative);

        }
        private void Nav2P2(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/Page2.xaml", UriKind.Relative);

        }
        private void Nav2About(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/About.xaml", UriKind.Relative);

        }
    }
}
