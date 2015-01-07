using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TheWhitworthian
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void NewsNav_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }

        private void ACNav_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }

        private void OpinionsNav_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }

        private void SportsNav_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }

        private void Search_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }
    }
}