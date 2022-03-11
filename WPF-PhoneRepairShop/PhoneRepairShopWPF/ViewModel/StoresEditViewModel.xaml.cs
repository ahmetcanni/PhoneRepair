using Les3WPF.Model;
using System.Collections.ObjectModel;

namespace Les3WPF.ViewModel
{
    public class StoresEditViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }

        public StoresEditViewModel(ObservableCollection<Store> stores)
        {
            Stores = stores; // set the property Stores (that is bound to the view) to be the collection we get passed from the other View
        }
    }
}
