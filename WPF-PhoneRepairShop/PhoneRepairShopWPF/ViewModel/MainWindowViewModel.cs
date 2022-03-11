using WPFPhoneRepairShop.Model;
using WPFPhoneRepairShop.View;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;

namespace WPFPhoneRepairShop.ViewModel
{
    public class MainWindowViewModel
    {
        private PhoneRepairDataModel _db = new PhoneRepairDataModel();
        public virtual ObservableCollection<Store> Stores { get; set; }
        public Store SelectedStore { get; set; }

        public virtual ObservableCollection<Customer> Customers { get; set; }
        public virtual ObservableCollection<Phone> SelectedPhone { get; set; }
        public RelayCommand StoresButtonClick { get; set; }
        public RelayCommand CustomersButtonClick { get; set; }
        public RelayCommand PhonesButtonClick { get; set; }

        public MainWindowViewModel()
        {

            StoresButtonClick = new RelayCommand(EditStores);
            CustomersButtonClick = new RelayCommand(EditCustomers);
            PhonesButtonClick = new RelayCommand(EditPhones);

            _db.Stores.Load();
            _db.Customers.Load();
            Stores = _db.Stores.Local;
            Customers = _db.Customers.Local;

            //Stores = new ObservableCollection<Store>
            //{
            //    new Store
            //    {
            //        StoreId = 001,
            //        Address = "Hoofdstraat 101",
            //        City = "Zwolle",
            //        MaxCapacity = 10,
            //        Customers = new ObservableCollection<Customer>
            //        {
            //            new Customer
            //            {
            //                FirstName = "Bob",
            //                LastName = "Stuurman",
            //                Gender = Gender.Male,
            //                CustomerId = 101,
            //                HeightCentimeter = 180,
            //                Email = "Beste.stuurlui.staan.aan.wal@gmail.com"
            //            },
            //            new Customer
            //            {
            //                FirstName = "Jan",
            //                LastName = "Spaak",
            //                Gender = Gender.Male,
            //                CustomerId = 102,
            //                HeightCentimeter = 175,
            //                Email = "j.spaak@hotmail.com"
            //            },
            //            new Customer
            //            {
            //                FirstName = "Maria",
            //                LastName = "Bel",
            //                Gender = Gender.Female,
            //                CustomerId = 103,
            //                HeightCentimeter = 170,
            //                Email = "maria.bel@yahoo.com"
            //            }

            //        },
            //        Phones = new ObservableCollection<Phone>
            //        {
            //            new Phone
            //            {
            //                PhoneModel = PhoneModel.Beachcruiser,
            //                PhoneColor = PhoneColor.Male,
            //                PhoneCapacity = PhoneCapacity.Medium,
            //                HourRate = 10.00,
            //                DayRate = 25.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Mountainbike,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Small,
            //                HourRate = 7.50,
            //                DayRate = 50.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Stadsfiets,
            //                PhoneColor = PhoneColor.Male,
            //                PhoneCapacity = PhoneCapacity.Medium,
            //                HourRate = 5.00,
            //                DayRate = 20.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Stadsfiets,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Large,
            //                HourRate = 5.00,
            //                DayRate = 20.00
            //            }

            //        }
            //    },
            //    new Store
            //    {
            //        StoreId = 002,
            //        Address = "Marktplein 10",
            //        City = "Leeuwarden",
            //        MaxCapacity = 10,
            //        Customers = new ObservableCollection<Customer>
            //        {
            //            new Customer
            //            {
            //                FirstName = "Jelle",
            //                LastName = "Snel",
            //                Gender = Gender.Male,
            //                CustomerId = 104,
            //                HeightCentimeter = 180,
            //                Email = "snelle.jelle@gmail.com"
            //            },
            //            new Customer
            //            {
            //                FirstName = "Aart",
            //                LastName = "Staartjes",
            //                Gender = Gender.Male,
            //                CustomerId = 105,
            //                HeightCentimeter = 180,
            //                Email = "a.staartjes@sesamstraat.nl"
            //            }

            //        },

            //    Phones = new ObservableCollection<Phone>
            //        {
            //            new Phone
            //            {
            //                PhoneModel = PhoneModel.Beachcruiser,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Large,
            //                HourRate = 10.00,
            //                DayRate = 25.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Mountainbike,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Small,
            //                HourRate = 7.50,
            //                DayRate = 50.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Stadsfiets,
            //                PhoneColor = PhoneColor.Male,
            //                PhoneCapacity = PhoneCapacity.Small,
            //                HourRate = 5.00,
            //                DayRate = 20.00
            //            },


            //        }
            //    },
            //    new Store
            //    {
            //        StoreId = 003,
            //        Address = "Stadhuisplein 10",
            //        City = "Almere",
            //        MaxCapacity = 10,
            //        Customers = new ObservableCollection<Customer>
            //        {
            //            new Customer
            //            {
            //                FirstName = "Hans",
            //                LastName = "B",
            //                Gender = Gender.Male,
            //                CustomerId = 106,
            //                HeightCentimeter = 170,
            //                Email = "H.b@windesheim.nl"
            //            },
            //            new Customer
            //            {
            //                FirstName = "Jan",
            //                LastName = "van R",
            //                Gender = Gender.Male,
            //                CustomerId = 107,
            //                HeightCentimeter = 185,
            //                Email = "j.van.r@windesheim.nl"
            //            }

            //        },

            //    Phones = new ObservableCollection<Phone>
            //        {
            //            new Phone
            //            {
            //                PhoneModel = PhoneModel.Beachcruiser,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Large,
            //                HourRate = 10.00,
            //                DayRate = 25.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Mountainbike,
            //                PhoneColor = PhoneColor.Female,
            //                PhoneCapacity = PhoneCapacity.Small,
            //                HourRate = 7.50,
            //                DayRate = 50.00
            //            },
            //            new Phone()
            //            {
            //                PhoneModel = PhoneModel.Stadsfiets,
            //                PhoneColor = PhoneColor.Male,
            //                PhoneCapacity = PhoneCapacity.Small,
            //                HourRate = 5.00,
            //                DayRate = 20.00
            //            },


            //       }
            //   }
            //};



        }
        public void EditStores(object a)
        {
            StoresEditViewModel editVM = new StoresEditViewModel(Stores, _db);
            StoresEdit view = new StoresEdit();
            view.DataContext = editVM;
            view.Show();
        }
        public void EditCustomers(object a)
        {
            if (SelectedStore == null)
            {
                MessageBox.Show("Select a store first");
            }
            else
            {
                CustomersEditViewModel editVM = new CustomersEditViewModel(SelectedStore.Customers, _db);
                CustomersEdit view = new CustomersEdit();
                view.DataContext = editVM;
                view.Show();
            }

        }
        public void EditPhones(object a)
        {
            if (SelectedStore == null)
            {
                MessageBox.Show("Select a store first");
            }
            else
            {
                PhonesEditViewModel editVM = new PhonesEditViewModel(SelectedStore.Phones, _db);
                PhonesEdit view = new PhonesEdit();
                view.DataContext = editVM;
                view.Show();
            }
        }

    };
}
