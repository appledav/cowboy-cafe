/*

* Author: David Apple

* Class name: MenuItemSelectionControl.xaml.cs

* Purpose: This class implements all the click events for all the buttons
*          on our window and has their logic 

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
using PointOfSale.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;
        public MenuItemSelectionControl()
        {

            InitializeComponent();
            AddCowpokeChili.Click += AddToOrderCowpokeChili;
            AddAngryChicken.Click += AddToOrderAngryChicken;
            AddBakedBeans.Click += AddToOrderBakedBeans;
            AddChiliCheeseFries.Click += AddToOrderChiliCheeseFries;
            AddCornDodgers.Click += AddToOrderCornDodgers;
            AddCowboyCoffee.Click += AddToOrderCowboyCoffee;
            AddDakotaDoubleBurger.Click += AddToOrderDakotaDoubleBurger;
            AddJerkedSoda.Click += AddToOrderJerkedSoda;
            AddPanDeCampo.Click += AddToOrderPanDeCampo;
            AddPecosPulledPork.Click += AddToOrderPecosPulledPork;
            AddRustlersRibs.Click += AddToOrderRustlersRibs;
            AddTexasTea.Click += AddToOrderTexasTea;
            AddTexasTripleBurger.Click += AddToOrderTexasTripleBurger;
            AddTrailBurger.Click += AddToOrderTrailBurger;
            AddWater.Click += AddToOrderWater;

            orderControl = this.FindAncestor<OrderControl>();

        }




        /// <summary>
        /// The event handler to add a trailburger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderTrailBurger(object sender, RoutedEventArgs e)
        {
            //currentOrder.Add(new TrailBurger());
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());

            }
        }

        /// <summary>
        /// The event handler to add water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderWater(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }

        }

        /// <summary>
        /// Event handler for the texas triple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderTexasTripleBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Event handler for the Texas tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderTexasTea(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// The event handler for the rustler ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderRustlersRibs(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }


        /// <summary>
        /// The event handler for the pulled pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderPecosPulledPork(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }


        /// <summary>
        /// The event handler for the pan de campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderPanDeCampo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// The event handler for the jerked soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderJerkedSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }

        }

        /// <summary>
        /// The event handler for the dakota double burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderDakotaDoubleBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// the event handler for the cowboy coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderCowboyCoffee(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// The event handler for the corn dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderCornDodgers(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// The event handler for the Chili Cheese fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderChiliCheeseFries(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// The event handler for the baked beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderBakedBeans(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// The event handler for the angry chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderAngryChicken(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// the event handler for the cowpoke chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderCowpokeChili(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = entree;
                data.Add(new CowpokeChili());
                orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
        }

    }
}
