using WPFPhoneRepairShop.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFPhoneRepairShop.ViewModel
{
    public class StoresEditViewModel
    {
        private PhoneRepairDataModel _db;
        public ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }
        public RelayCommand DeleteStoreClick { get; set; }
        public RelayCommand AddStoreClick { get; set; }
        public RelayCommand SaveClick { get; set; }

        //public Phone SelectedPhone { get; set; }

        public StoresEditViewModel(ObservableCollection<Store> stores, PhoneRepairDataModel db)
        {
            _db = db;
            Stores = stores; // set the property Stores (that is bound to the view) to be the collection we get passed from the other View
            DeleteStoreClick = new RelayCommand(DeleteStore);
            AddStoreClick = new RelayCommand(AddStore);
            SaveClick = new RelayCommand(x => _db.SaveChanges());
        }

       
     
        public void DeleteStore(object a)
        {
            if (SelectedStore != null)
            {
                Stores.Remove(SelectedStore);
            }
            else
            {
                MessageBox.Show("Please select a store first");
            }
        }
        public virtual void AddStore(object a)
        {
            Stores.Add(
                new Store
                {
                    Address = "New Location",
                    City = "New City",
                    MaxCapacity = 0,
                    
                });
        }

    }
}
