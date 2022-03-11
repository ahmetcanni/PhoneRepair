using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFPhoneRepairShop.Model
{
    public class Store : INotifyPropertyChanged
    {
        private string _address;
        private string _city;
        private int _maxCapacity;
        private ObservableCollection<Customer> _customers;
        private ObservableCollection<Phone> _phones;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public string Address { get => _address; set { _address = value; Notify("Address"); } }
        public string City { get => _city; set { _city = value; Notify("City"); } }
        public int MaxCapacity { get => _maxCapacity; set { _maxCapacity = value; Notify("MaxCapacity"); } }
        public virtual ObservableCollection<Customer> Customers { get => _customers; set { _customers = value; Notify("Customers"); } }
        public virtual ObservableCollection<Phone> Phones { get => _phones; set { _phones = value; Notify("Phones"); } }

        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Store()
        {
            Customers = new ObservableCollection<Customer>();
            Phones = new ObservableCollection<Phone>();
        }
    }
}
