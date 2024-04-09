using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfApp2
{
    public class NavigateButtonBehaivior: Behavior<ButtonBase>
    {
        public static readonly DependencyProperty NavigateProperty =
            DependencyProperty.Register("NavigatePage",typeof(Uri),typeof(NavigateButtonBehaivior),new UIPropertyMetadata(null));
        
        public static readonly DependencyProperty NavigateExtraDataProperty =
            DependencyProperty.Register("NavigateExtraData", typeof(object), typeof(NavigateButtonBehaivior), new UIPropertyMetadata(null));
    
    
        public Uri NavigatePage 
        {
            get { return (Uri)GetValue(NavigateProperty); }
            set { SetValue(NavigateProperty,null); }
        }

        public object NavigateExtraData 
        {
            get { return GetValue(NavigateExtraDataProperty); }
            set { SetValue(NavigateExtraDataProperty,null); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Click+=this.AssociatedObjectClick;
        }
        private void AssociatedObjectClick(object sender,RoutedEventArgs e) 
        {
            if (this.NavigatePage==null) 
            {
                return;
            }

            var button = (ButtonBase)sender;
            NavigationService navigationService = (NavigationService)GetNavigationService(button);
            if (navigationService==null) {
                return;
            }

            var baseUri = BaseUriHelper.GetBaseUri(button);
            var uri = new Uri(baseUri,this.NavigatePage);
           navigationService.Navigate(uri,this.NavigateExtraData);

        }

        private object GetNavigationService(DependencyObject dependencyObject)
        {
            var window = Window.GetWindow(dependencyObject);
            if (window is NavigationWindow window1) 
            {
                return window1.NavigationService;
            }
            var parent = dependencyObject;
            while ((parent=VisualTreeHelper.GetParent(parent))!=null) 
            {
                if (parent is Frame frame) 
                {
                    return frame.NavigationService;
                }
            }
            return null;
        }
    }
}
