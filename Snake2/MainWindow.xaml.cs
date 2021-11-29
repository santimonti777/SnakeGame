﻿using System;
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

namespace Snake2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Ellipse ellSerp = new Ellipse()
                {
                    Fill = Brushes.Tomato,
                    Width = 10,
                    Height = 10
                };
                canvas.Children.Add(ellSerp);
                Canvas.SetTop(ellSerp, canvas.ActualHeight / 2);
                Canvas.SetLeft(ellSerp, canvas.ActualWidth / 2);
            }
        }
    }
}
