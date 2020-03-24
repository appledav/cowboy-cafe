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

            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                screen.DataContext = entree;
                data.Add(new TrailBurger());
                orderControl.SwapScreen(new CustomizeTrailBurger());
            }
        }

        /// <summary>
        /// The event handler to add water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderWater(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new Water();
                var screen = new CustomizeWater();
                screen.DataContext = entree;
                data.Add(new Water());
                orderControl.SwapScreen(new CustomizeWater());
            }

        }

        /// <summary>
        /// Event handler for the texas triple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderTexasTripleBurger(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                screen.DataContext = entree;
                data.Add(new TexasTripleBurger());
                orderControl.SwapScreen(new CustomizeTexasTripleBurger());
            }
        }

        /// <summary>
        /// Event handler for the Texas tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderTexasTea(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTea();
                var screen = new CustomizeTexasTea();
                screen.DataContext = entree;
                data.Add(new TexasTea());
                orderControl.SwapScreen(new CustomizeTexasTea());
            }
        }

        /// <summary>
        /// The event handler for the rustler ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderRustlersRibs(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new RustlersRibs();
                var screen = new CustomizeRustlersRibs();
                screen.DataContext = entree;
                data.Add(new RustlersRibs());
                orderControl.SwapScreen(new CustomizeRustlersRibs());
            }
        }


        /// <summary>
        /// The event handler for the pulled pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderPecosPulledPork(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                screen.DataContext = entree;
                data.Add(new PecosPulledPork());
                orderControl.SwapScreen(new CustomizePecosPulledPork());
            }
        }


        /// <summary>
        /// The event handler for the pan de campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderPanDeCampo(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new PanDeCampo();
                var screen = new CustomizePanDeCampo();
                screen.DataContext = entree;
                data.Add(new PanDeCampo());
                orderControl.SwapScreen(new CustomizePanDeCampo());
            }
        }

        /// <summary>
        /// The event handler for the jerked soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderJerkedSoda(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                screen.DataContext = entree;
                data.Add(new JerkedSoda());
                orderControl.SwapScreen(new CustomizeJerkedSoda());
            }

        }

        /// <summary>
        /// The event handler for the dakota double burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderDakotaDoubleBurger(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                screen.DataContext = entree;
                data.Add(new DakotaDoubleBurger());
                orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
            }
        }

        /// <summary>
        /// the event handler for the cowboy coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderCowboyCoffee(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                screen.DataContext = entree;
                data.Add(new CowboyCoffee());
                orderControl.SwapScreen(new CustomizeCowboyCoffee());
            }
        }

        /// <summary>
        /// The event handler for the corn dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderCornDodgers(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CornDodgers();
                var screen = new CustomizeCornDodgers();
                screen.DataContext = entree;
                data.Add(new CornDodgers());
                orderControl.SwapScreen(new CustomizeCornDodgers());
            }
        }

        /// <summary>
        /// The event handler for the Chili Cheese fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderChiliCheeseFries(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new ChiliCheeseFries();
                var screen = new CustomizeChiliCheeseFries();
                screen.DataContext = entree;
                data.Add(new ChiliCheeseFries());
                orderControl.SwapScreen(new CustomizeChiliCheeseFries());
            }
        }

        /// <summary>
        /// The event handler for the baked beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderBakedBeans(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new BakedBeans();
                var screen = new CustomizeBakedBeans();
                screen.DataContext = entree;
                data.Add(new BakedBeans());
                orderControl.SwapScreen(new CustomizeBakedBeans());
            }
        }

        /// <summary>
        /// The event handler for the angry chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrderAngryChicken(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                screen.DataContext = entree;
                data.Add(new AngryChicken());
                orderControl.SwapScreen(new CustomizeAngryChicken());
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
