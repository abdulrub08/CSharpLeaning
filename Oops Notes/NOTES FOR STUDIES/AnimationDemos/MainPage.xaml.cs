using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AnimationDemos
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Start Animation
            myColorAnimation.To = Color.FromArgb(255, 255, 255, 255);
            mystoryboard.Begin();


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Stop Animation
            mystoryboard.Stop();
            
        }
    }
}
