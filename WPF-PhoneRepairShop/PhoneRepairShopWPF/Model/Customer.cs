using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFPhoneRepairShop.Model
{
    public class Customer : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private Gender _gender;
        private ObservableCollection<Store> _stores;

        public int Id { get; set; }
        public int HeightCentimeter { get; set; }
        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName { get => _firstName; set { _firstName = value; Notify("FirstName"); } }
        public string LastName { get => _lastName; set { _lastName = value; Notify("LastName"); } }
        public Gender Gender { get => _gender; set { _gender = value; Notify("Gender"); } }
        public ObservableCollection<Store> Stores { get => _stores; set { _stores= value; Notify("Stores"); } }
        
        public Customer()
        {
            Stores = new ObservableCollection<Store>();
        }

        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Gender
        {
            Male,
            Female,
            None
        }
}
