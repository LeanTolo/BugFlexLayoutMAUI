using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFlexLayout
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> collectionToShow;
        
        [ObservableProperty]
        IEnumerable<string> ienumerableToShow;
        public IRelayCommand OnAddToCollectionClickedCommand { get; }

        public MainViewModel()
        {
            OnAddToCollectionClickedCommand = new RelayCommand(OnAddToCollectionClicked);
        }

        [RelayCommand]
        public void OnAddToCollectionClicked()
        {
            CollectionToShow = new ObservableCollection<string>();

            CollectionToShow.Add("test1Collection");
            CollectionToShow.Add("test2Collection");
            CollectionToShow.Add("test3Collection");
            CollectionToShow.Add("test4Collection");
            IenumerableToShow = new List<string>()
            {
                "test1IEnumerable//List",
                "test2IEnumerable//List",
                "test3IEnumerable//List",
                "test4IEnumerable//List"
            };
        }
    }
}
