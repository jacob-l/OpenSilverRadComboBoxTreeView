using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using SelectionChangedEventArgs = Telerik.Windows.Controls.SelectionChangedEventArgs;

namespace OpenSilverRadComboBoxTreeView
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        private void TreeView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var treeView = (RadTreeView)sender;
            var selectedItem = treeView.SelectedItem.ToString();

            MyDropDownButton.Content = selectedItem;
            MyDropDownButton.IsOpen = false; // Close the dropdown
        }
    }
}
