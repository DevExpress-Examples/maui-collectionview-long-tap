using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewWithActionButtons.ViewModels {

    [QueryProperty(nameof(ParentCard), "Parent")]
    internal class CompleteListViewModel : INotifyPropertyChanged {
        public Card parentCard;
        public Card ParentCard {
            get { return parentCard; }
            set {
                parentCard = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
