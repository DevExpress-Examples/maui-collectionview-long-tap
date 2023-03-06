using System;
using Foundation;
using Microsoft.Maui.Controls;
using UIKit;

namespace CollectionViewWithActionButtons {
    internal partial class ThemeLoader {
        public void UpdateStatusBar() {
            Application.Current.Dispatcher.Dispatch(() => {
                // UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.DarkContent, true);
                GetCurrentViewController().SetNeedsStatusBarAppearanceUpdate();
            });
        }
        UIViewController GetCurrentViewController() {
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            UIViewController viewController = window.RootViewController;
            while (viewController.PresentedViewController != null)
                viewController = viewController.PresentedViewController;
            return viewController;
        }
    }
}