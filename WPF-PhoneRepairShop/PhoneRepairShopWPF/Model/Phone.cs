using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WPFPhoneRepairShop.Model
{
    public class Phone : INotifyPropertyChanged
    {
        private PhoneModel _phoneModel;
        private PhoneColor _phoneColor;
        private PhoneCapacity _phoneCapacity;
        private string _brand;
        private double _hourRate;
        private double _dayRate;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public PhoneModel PhoneModel { get => _phoneModel; set { _phoneModel = value; Notify("PhoneModel"); } }
        public PhoneColor PhoneColor { get => _phoneColor; set { _phoneColor = value; Notify("PhoneColor"); } }
        public PhoneCapacity PhoneCapacity { get => _phoneCapacity; set { _phoneCapacity = value; Notify("PhoneCapacity"); } }
        public string Brand { get => _brand; set { _brand = value; Notify("Brand"); } }
        public double HourRate { get => _hourRate; set { _hourRate = value; Notify("HourRate"); } }
        public double DayRate { get => _dayRate; set { _dayRate = value; Notify("DayRate"); } }


        public virtual ObservableCollection<Phone> Phones { get; set; }
        public Phone()
        {
            Phones = new ObservableCollection<Phone>();
        }

        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    public enum PhoneModel
    {
        None,
        iPhoneX,
        iPhoneXr,
        iPhoneXs,
        iPhoneXsMax,
        iPhone11,
        iPhone11Pro,
        iPhone11ProMax,
        iPhoneSE,
        iPhone12Mini,
        iPhone12,
        iPhone12Pro,
        iPhone12ProMax,
        iPhone13Mini,
        iPhone13,
        iPhone13Pro,
        iPhone13ProMax
    }
    public enum PhoneColor
    {
        None,
        Black,
        Red,
        Blue,
        Green
        
    }


    public enum PhoneCapacity
    {
        ScreenReplacement,
        BatteryReplacement,
        OtherDamage
    }

}
