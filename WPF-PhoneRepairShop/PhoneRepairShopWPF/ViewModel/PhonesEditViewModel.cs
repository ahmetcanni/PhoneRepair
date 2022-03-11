using WPFPhoneRepairShop.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFPhoneRepairShop.ViewModel
{
    public class PhonesEditViewModel
    {
        private PhoneRepairDataModel _db;
        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone { get; set;}
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand AddClick { get; set; }
        public RelayCommand SaveClick { get; set; }

        public PhonesEditViewModel(ObservableCollection<Phone> phones, PhoneRepairDataModel db)
        {
            _db = db;
            Phones = phones; // set the property Stores (that is bound to the view) to be the collection we get passed from the other View
        
            DeleteClick = new RelayCommand(DeletePhone);
            AddClick = new RelayCommand(AddPhone);
            SaveClick = new RelayCommand(x => _db.SaveChanges());

        }


        public void DeletePhone(object a)
        {
            if (SelectedPhone != null)
            {
                Phones.Remove(SelectedPhone);
            }
            else
            {
                MessageBox.Show("Please select a phone first");
            }
        }

        public void AddPhone(object a)
        {
            Phones.Add(
                        new Phone
                        {
                            PhoneModel = PhoneModel.None,
                            PhoneColor = PhoneColor.None,
                            HourRate = 0.00,
                            DayRate = 0.00
                        });
        }

    }
}
