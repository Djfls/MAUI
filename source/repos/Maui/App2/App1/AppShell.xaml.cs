using App1.View;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppShell : Page
    {
        public Frame AppFrame => frame;
        public readonly string OrderListLabel = "Order list";
        public readonly string CustomerListLabel = "Customer list";

        public AppShell()
        {
            this.InitializeComponent();
        }

        private void Page_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            FocusNavigationDirection focusNavigationDirection = FocusNavigationDirection.None;
            switch (e.Key)
            {
                case VirtualKey.Left:
                case VirtualKey.GamepadDPadLeft:
                case VirtualKey.GamepadLeftThumbstickLeft:
                case VirtualKey.NavigationLeft:
                    focusNavigationDirection = FocusNavigationDirection.Left;
                    break;
                case VirtualKey.Right:
                case VirtualKey.GamepadDPadRight:
                case VirtualKey.GamepadLeftThumbstickRight:
                case VirtualKey.NavigationRight:
                    focusNavigationDirection = FocusNavigationDirection.Right;
                    break;

                case VirtualKey.Up:
                case VirtualKey.GamepadDPadUp:
                case VirtualKey.GamepadLeftThumbstickUp:
                case VirtualKey.NavigationUp:
                    focusNavigationDirection = FocusNavigationDirection.Up;
                    break;

                case VirtualKey.Down:
                case VirtualKey.GamepadDPadDown:
                case VirtualKey.GamepadLeftThumbstickDown:
                case VirtualKey.NavigationDown:
                    focusNavigationDirection = FocusNavigationDirection.Down;
                    break;
            }
            if (focusNavigationDirection != FocusNavigationDirection.None &&
                FocusManager.FindNextFocusableElement(focusNavigationDirection) is Control control)
            {
                control.Focus(FocusState.Keyboard);
                e.Handled = true;
            }
        }

        private void frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
            {
                if (e.SourcePageType == typeof(Page1))
                {
                    NavView.SelectedItem = CustomerListMenuItem;
                }
                else if(e.SourcePageType==typeof(Page2))
                {
                    NavView.SelectedItem = OrderListMenuItem;
                }
                else if (e.SourcePageType == typeof(Page3))
                {
                    NavView.SelectedItem = NavView.SettingsItem;
                }
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {

        }
    }
}
