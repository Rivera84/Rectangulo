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

namespace Rectangulo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ClassRectangulo Rectangulo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Rectangulo = new ClassRectangulo { x1="5", x2="5",y1="3", y2="3" };
            this.DataContext = Rectangulo;
        }
    }
}
