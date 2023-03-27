<!-- default badges list -->
<!-- default badges end -->
# Select Multiple Items within the DevExpress CollectionView for .NET MAUI

This example shows how you can use our [DXCollectionView.LongPress](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView.LongPress?v=23.1) event to implement a multiple item selection.

## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## Implementation Details

* Set the [DXCollectionView.SelectionMode](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView.SelectionMode?v=23.1) property to [Multiple](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.selectionmode?view=net-maui-7.0) to enable multi-select mode.
* Handle the [DXCollectionView.LongPress](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView.LongPress?v=23.1) event or call the 
* Use the [DXCollectionView.SelectedItemTemplate](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView.SelectedItemTemplate?v=23.1) property to specify the selected item's template.
* You can define a common part for the selected and regular items in a separate class. This example uses the ContentView's SelectableItem descendant class that contains the IsSelected property. The appearance of this class is defined in the itemBaseTemplate.
* Define the items in the [Shell.TitleView](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/pages?view=net-maui-7.0#display-views-in-the-navigation-bar) property to display them in the application's title when the CollectionView item is selected.

## Files to Review

<!-- default file list -->
* [MainPage.xaml](./CS/MainPage.xaml)
* [MainPage.xaml.cs](./CS/MainPage.xaml.cs)
* [MainViewModel.cs](./CS/MainViewModel.cs)
* [Converters.cs](./CS/Converters.cs)
* [App.xaml](./CS/App.xaml)
<!-- default file list end -->

## Documentation

- [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet?v=23.1)
- [SimpleButtons](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.SimpleButton)

## More Examples

* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Demo Application](https://github.com/DevExpress-Examples/maui-demo-app)
