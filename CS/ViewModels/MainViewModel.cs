using CollectionViewWithActionButtons.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CollectionViewWithActionButtons.ViewModels {
    public class ViewModel : BindableBase {
        public ViewModel() {
            Cards = DataGenerator.CreateCards();
        }
        public ObservableCollection<Card> Cards { get; set; }
    }

    public class Card : BindableBase {
        public Card(string title) {
            Title = title;
            HideCommand = new Command<CardItem>(HideItem);
            NavigateToAllCommand = new Command(NavigateToAll);
            ItemClickCommand = new Command<CardItem>(ItemClick);
            PrimaryActionCommand = new Command(PrimaryAction);
            SecondaryActionCommand = new Command(SecondaryAction);
        }

        public string Title { get; }
        public ICommand HideCommand { get; }
        public ICommand NavigateToAllCommand { get; }
        public ICommand ItemClickCommand { get; }
        public ICommand PrimaryActionCommand { get; }
        public ICommand SecondaryActionCommand { get; }
        public bool AllowCommonActions { get; set; }
        public string PrimaryActionName { get; set; }
        public string SecondaryActionName { get; set; }
        public int PreviewItemsCount { get; set; }
        public void HideItem(CardItem itemToHide) {
            TopItems.Remove(itemToHide);
            Items.Remove(itemToHide);
        }
        public async void ItemClick(CardItem clickedItem) {
            if (clickedItem == null) return;
            await Application.Current.MainPage.DisplayAlert("Item Click", clickedItem.Name, "OK");
        }
        public async void NavigateToAll() {
            var navigationParameter = new Dictionary<string, object> { { "Parent", this } };
            await Shell.Current.GoToAsync("completeList", navigationParameter);
        }
        public async void PrimaryAction() {
            await Application.Current.MainPage.DisplayAlert("Primary Action", "Click", "OK");
        }
        public async void SecondaryAction() {
            await Application.Current.MainPage.DisplayAlert("Secondary Action", "Click", "OK");
        }
        public ObservableCollection<CardItem> Items { get; set; } = new ObservableCollection<CardItem>();
        public ObservableCollection<CardItem> TopItems { get; } = new ObservableCollection<CardItem>();
    }

    public class CardItem : BindableBase {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public ImageSource Icon { get; set; }
    }

    public class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

