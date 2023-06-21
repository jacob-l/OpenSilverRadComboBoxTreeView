using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.Animation;

namespace OpenSilverRadComboBoxTreeView
{
    public sealed partial class App : Application
    {
        public App()
        {
            AnimationManager.IsGlobalAnimationEnabled = false;
            Host.Settings.EnableOptimizationWhereCollapsedControlsAreNotLoaded = true;

            this.InitializeComponent();

            // Enter construction logic here...

            var mainPage = new MainPage();
            Window.Current.Content = mainPage;
        }
    }
}
