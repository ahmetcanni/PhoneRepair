using WPFPhoneRepairShop.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFPhoneRepairShop.ViewModel
{
    public class CustomersEditViewModel
    {
        private PhoneRepairDataModel _db;
        public ObservableCollection<Customer> Customers { get; set; }
        public Customer SelectedCustomer { get; set; }
        public RelayCommand ChangeNameClick { get; set; }
        public RelayCommand DeleteClick {get; set; }
        public RelayCommand AddClick { get; set; }
        public RelayCommand SaveClick { get; set; }

        public CustomersEditViewModel(ObservableCollection<Customer> customers, PhoneRepairDataModel db)
        {
            _db = db;
            Customers = customers; // set the property Customers (that is bound to the view) to be the collection we get passed from the other View
            ChangeNameClick = new RelayCommand(ChangeName);
            DeleteClick = new RelayCommand(DeleteCustomer);
            AddClick = new RelayCommand(AddCustomer);
            SaveClick = new RelayCommand(x => _db.SaveChanges());
        }

        public void ChangeName(object a)
        {
            if(SelectedCustomer != null)
            {
                SelectedCustomer.LastName = "CHANGED LASTNAME";
            }
            else
            {
                MessageBox.Show("Please select a customer first");
            }
        }

        public void DeleteCustomer(object a)
        {
            if(SelectedCustomer != null)
            {
                Customers.Remove(SelectedCustomer);
            }
            else
            {
                MessageBox.Show("Please select a customer first");
            }
        }
        public void AddCustomer(object a)
        {
          Customers.Add(
                    new Customer
                    {
                        FirstName = "FIRST NAME",
                        LastName = "LAST NAME",
                        Gender = Gender.None,
                        Id = 100,
                        HeightCentimeter = 0,
                        Email = "MAIL@MAIL.COM"
                    });
        }            
    }
}
