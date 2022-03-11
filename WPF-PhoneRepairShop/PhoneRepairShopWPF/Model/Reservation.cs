using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFPhoneRepairShop.Model
{
    public class Reservation : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Phone Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Store PickupStore { get; set; }
        public virtual Store DropoffStore { get; set; }
        public double TotalPrice {get; set;}

        public event PropertyChangedEventHandler PropertyChanged;
    }
    //public Reservation()
    //{
    //    Customers = new ObservableCollection<Customer>();
    //    Phones = new ObservableCollection<Phone>();
    //    PickupStore = new ObservableCollection<Store>();
    //    DropoffStore = new ObservableCollection<Store>();
    //}
}
