﻿/*

* Author: David Apple

* Class name: MainWindow.xaml.cs

* Purpose: This class implements our main window of our WPF

*/

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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Order currentOrder = new Order();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = currentOrder;
            
        }
    }
}
