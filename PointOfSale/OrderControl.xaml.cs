/*

* Author: David Apple

* Class name: OrderControl.xaml.cs

* Purpose: The class that implements the Order control window
*           All the click events are located in here to control the flow of the program

*/


using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
       
        public OrderControl()
        {

            InitializeComponent();
            //ItemSelection.Click += OnItemSelectionClick();
            CompleteOrder.Click += OnCompleteOrderClick;
            CancelOrder.Click += OnCancelOrderClick;

        }

        /// <summary>
        /// Handler for the cancel order click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Handler for the Complete order click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        
    }
}
